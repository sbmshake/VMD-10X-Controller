using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMD_10X_Controller
{
    public static class VMD
    {
        private struct TimeControl
        {
            public long Duration;
            public long Previous;
            public long Delta;
        }
        protected class Request
        {
            public partial class Type
            {
                public const byte GetState = 0;
                public const byte GetPosition = 1;
                public const byte Start = 2;
                public const byte SetSteps = 3;
                public const byte SetDirection = 4;
                public const byte SetSpeed = 5;
                public const byte SetAcceleration = 6;
                public static string GetSymbol(byte type)
                {
                    switch (type)
                    {
                        case GetState: return "I";
                        case GetPosition: return "P";
                        case Start: return "R";
                        case SetSteps: return "S";
                        case SetDirection: return "D";
                        case SetSpeed: return "V";
                        case SetAcceleration: return "A";
                        default: return string.Empty;
                    }
                }
            }

            protected string question;
            public string Response;
            protected bool hidden;
            public byte TypeOf;

            public Request(byte type, string message, bool hidden)
            {
                TypeOf = type;
                question = message;
                Response = string.Empty;
                this.hidden = hidden;
                PortCOM.WriteLine(question + "\r\n");
            }
            public void Log()
            {
                if (!hidden)
                {
                    AppVar.mainForm.WriteToPortLog(question, false);
                    AppVar.mainForm.WriteToPortLog(Response, true);
                }
            }
        }
        public static class Direction
        {
            public const byte CCW = 0;
            public const byte CW = 1;
            public static string[] NameCollection { set; get; } = new string[]
            {
                "CCW",
                "CW"
            };
        }
        public static class Axis
        {
            public const byte UpperHorizontal = 0;
            public const byte LowerHorizontal = 1;
            public const byte UpperVertical = 2;
            public const byte LowerVertical = 3;

            public static byte Value { set; get; }
            public static string[] NameCollection { set; get; } = new string[]
            {
                "Upper Horizontal",
                "Lower Horizontal",
                "Upper Vertical",
                "Lower Vertical"
            };
            public static string GetDescription(byte value) =>
                (value >= 0 && value < 4) ? NameCollection[value] : string.Empty;
            public static byte GetAxisNumber(string name) =>
                (byte)NameCollection.ToList().IndexOf(name);
        }

        private static byte inMotion;
        private static List<int[]> positionList;
        private static int[] positionNow;
        private static int[] positionPrev;
        private static int[] positionBase;
        private static List<Request> requests;
        public static bool Online;
        private static bool recording;
        private static Task savePositionTask;
        private static TimeControl timeRecording;
        private static TimeControl timeRunning;
        private static long timeNow;
        public static double SampleTime;
        public static bool Recording
        {
            set
            {
                recording = value;
                if (recording)
                {
                    timeRecording.Previous = DateTime.Now.Ticks;
                    timeRecording.Delta = 0;
                    timeRecording.Duration = 0;
                    AppVar.mainForm.OpenPositionFile();
                }
                else
                {
                    AppVar.mainForm.ClosePositionFile();
                }
            }
            get
            {
                return recording;
            }
        }
        private static bool running;
        public static bool Running
        {
            set
            {
                running = value;
                if (running)
                {
                    timeRunning.Previous = DateTime.Now.Ticks;
                    timeRunning.Delta = 0;
                    timeRunning.Duration = 0;
                }
                else
                {
                    PortCOM.Clear();
                }
            }
            get
            {
                return running;
            }
        }
        public static void Initialize()
        {
            positionList = new List<int[]>();
            positionNow = new int[4];
            positionPrev = new int[] { 0, 0, 0, 0};
            positionBase = new int[4];
            inMotion = 4;
            Online = false;
            recording = false;
            timeNow = DateTime.Now.Ticks;
            requests = new List<Request>();
            PortCOM.Initialize("COM8", 460800);
        }
        private static void WhileInMotion()
        {
            while (Running)
            {
                timeNow = DateTime.Now.Ticks;
                if (Recording)
                {
                    Send(Request.Type.GetPosition, inMotion);
                }
                long dTime = timeNow - timeRunning.Previous;
                timeRunning.Duration += dTime;
                timeRunning.Delta += dTime;
                timeRunning.Previous = timeNow;
                if (timeRunning.Delta / TimeSpan.TicksPerMillisecond > 500)
                {
                    timeRunning.Delta = 0;
                    Send(Request.Type.GetState, inMotion);
                }

                Recive();
            }
        }
        public static void Send(byte type, byte axis, int val = -1)
        {
            requests.Add(new Request(type,
                Request.Type.GetSymbol(type) +                          // Command
                axis.ToString() +                                       // Axis
                ((val >= 0) ? (" " + val.ToString()) : string.Empty),   // alt. Value
                false));                                                // EoL
            if (type == Request.Type.Start)
            {
                Running = true;
                inMotion = axis;
                WhileInMotion();
            }
        }
        public static void Recive()
        {
            var response = PortCOM.ReadAll().Split(new string[] { "\r\n\0" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            while (response.Count() > 0)
            {
                byte type = requests[0].TypeOf;
                if (response[0].Contains(Request.Type.GetSymbol(type)))
                {
                    requests[0].Response = response[0];
                    response.RemoveAt(0);
                    if (response.Count() > 0 &&
                        (type == Request.Type.GetPosition || type == Request.Type.GetState))
                    {
                        {
                        /*
                        if (type == Request.Type.GetPosition)
                        {
                            if (inMotion >= 0 && inMotion < 4)
                            {
                                positionNow[inMotion] = int.Parse(response[0]);
                                if (Recording)
                                {
                                    timeRecording.Delta += timeNow - timeRecording.Previous;
                                    timeRecording.Previous = timeNow;
                                    int count = (int)(timeRecording.Delta / TimeSpan.TicksPerMillisecond / SampleTime);
                                    if (count > 0)
                                    {
                                        int[] positionDelta = new int[4];
                                        for (int i = 0; i < 4; i++)
                                        {
                                            positionDelta[i] = (int)(1.0 * positionNow[i] - positionPrev[i] / count);

                                        };
                                        for (int i = 0; i < count; i++)
                                        {
                                            int[] positionTemp = new int[4];
                                            for (int j = 0; j < 4; j++)
                                            {
                                                positionTemp[j] = (int)(1.0 * positionNow[j] + i * positionDelta[j]);
                                            };
                                            positionList.Add(positionTemp);
                                        }
                                        int[] tmp = new int[4];
                                        Array.Copy(positionNow, tmp, 4);
                                        positionList.Add(tmp);
                                        positionNow.CopyTo(positionPrev, 0);
                                        timeRecording.Duration += timeRecording.Delta;
                                        timeRecording.Delta = 0;
                                    }

                                    do
                                    {
                                        if (savePositionTask == null)
                                        {
                                            savePositionTask = new Task(() => AppVar.mainForm.SavePositionTask(positionList));
                                            savePositionTask.Start();
                                        }
                                        else if (savePositionTask.IsCompleted ||
                                            savePositionTask.IsFaulted ||
                                            savePositionTask.IsCanceled)
                                        {
                                            savePositionTask.Dispose();
                                            savePositionTask = null;
                                        }
                                    } while (savePositionTask == null);
                                }
                            }
                        }
                        else
                        */
                        }
                        if (response[0].Contains("RDY"))
                        {
                            Running = false;
                            inMotion = 4;
                        }
                        requests[0].Response += "\n" + response[0];
                        response.RemoveAt(0);
                    }
                    requests[0].Log();
                    requests.RemoveAt(0);
                }
            }
        }
        public static ushort DistToSteps(byte axis, double val)
        {
            switch (axis)
            {
                case Axis.UpperHorizontal: return (ushort)(val * 160);
                case Axis.LowerHorizontal: return (ushort)(val * 160);
                case Axis.UpperVertical: return (ushort)(val * 455);
                case Axis.LowerVertical: return (ushort)(val * 450);
                default: return 0;
            }
        }
        public static double StepsToDist(byte axis, double val)
        {
            switch (axis)
            {
                case Axis.UpperHorizontal: return val / 160;
                case Axis.LowerHorizontal: return val / 160;
                case Axis.UpperVertical: return val / 455;
                case Axis.LowerVertical: return val / 450;
                default: return 0;
            }
        }

        public static class BasicMoves
        {
            public static void Move(byte axis, ushort dir, ushort steps, ushort speed, ushort acc)
            {
                Online = true;
                Send(Request.Type.SetDirection, axis, dir);
                Send(Request.Type.SetSteps, axis, steps);
                Send(Request.Type.SetSpeed, axis, speed);
                Send(Request.Type.SetAcceleration, axis, acc);
                Send(Request.Type.Start, axis);
                Online = false;
            }
            public static void Play(string[] commands)
            {
                /*
                Online = true;
                for (int i = 0; i < commands.Count(); i++)
                {
                    Send(commands[i]);
                }
                */
            }
            public static void Scan(byte pAxis, byte pDir, ushort pSpeed, ushort pDist, ushort between, byte sAxis, byte sDir, ushort sSpeed, ushort sDist, ushort acc)
            {
                Online = true;
                ushort distLeft = pDist;
                byte sdir = sDir;
                Send(Request.Type.SetDirection, pAxis, pDir);
                Send(Request.Type.SetDirection, sAxis, sDir);
                Send(Request.Type.SetSpeed, pAxis, pSpeed);
                Send(Request.Type.SetSpeed, sAxis, sSpeed);
                Send(Request.Type.SetAcceleration, pAxis, acc);
                Send(Request.Type.SetAcceleration, sAxis, acc);
                Send(Request.Type.SetSteps, pAxis, between);
                Send(Request.Type.SetSteps, sAxis, sDist);
                while (distLeft >= between)
                {
                    Send(Request.Type.Start, sAxis);
                    Send(Request.Type.Start, pAxis);
                    sdir = (byte)(1 - sdir);
                    Send(Request.Type.SetDirection, sAxis, sdir);
                    distLeft -= between;
                }
                Send(Request.Type.Start, sAxis);
                Send(Request.Type.SetSteps, pAxis, distLeft);
                Send(Request.Type.Start, pAxis);
                sdir = (byte)(1 - sdir);
                Send(Request.Type.SetDirection, sAxis, sdir);
                Send(Request.Type.Start, sAxis);
                Online = false;
            }
            public static void SetBase()
            {
                Online = true;
                for (int i = 0; i < 4; i++)
                {
                    inMotion = (byte)i;
                    Send(Request.Type.GetPosition, inMotion);
                    Recive();
                }
                Online = false;
                positionNow.CopyTo(positionBase, 0);
            }
            public static void GotoBase()
            {
                Online = true;
                for(int i = 0; i < 4; i++)
                {
                    inMotion = (byte)i;
                    Send(Request.Type.GetPosition, inMotion);
                    Recive();
                    Move((byte)i, (byte)(positionNow[i] < positionBase[i] ? 1 : 0), (ushort)Math.Abs(positionNow[i] - positionBase[i]), 1000, 1000);
                }
                Online = false;
            }
        }
    }
}
