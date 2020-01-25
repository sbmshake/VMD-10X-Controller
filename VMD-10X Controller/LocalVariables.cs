using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMD_10X_Controller
{
    public static class AppVar
    {
        public static byte Mode;
        public static MainForm mainForm;
        public static byte appState;

        public static void Initialize(MainForm mf)
        {
            mainForm = mf;
            PortCOM.State.Value = PortCOM.State.NoPort;
            AppState.Value = AppState.Ready;
        }
        public static void Log(string message, bool important)
        {
            mainForm.appLog1.Add(message, important);
        }
    }
    public static class ProgrammingMode
    {
        public const byte Positioning = 0;
        public const byte Scan = 1;
        public const byte Simplified = 2;
        public const byte Professional = 3;

        private static byte val;
        public static byte Value
        {
            set
            {
                val = value;
                AppVar.mainForm.groupBox_mode.Text = GetDescription();
                AppVar.Log("Serial Port state changed to \"" + GetDescription() + "\"", false);
            }
            get
            {
                return val;
            }
        }
        public static string GetDescription()
        {
            switch (Value)
            {
                case Positioning: return "Positioning";
                case Scan: return "Scan 2D";
                case Simplified: return "Simplified";
                case Professional: return "Professional";
                default: return string.Empty;
            }
        }
    }
    public static class AppState
    {
        public const byte Ready = 0;
        public const byte Busy = 1;
        public const byte Error = 2;

        private static byte val;
        public static byte Value
        {
            set
            {
                val = value;
                AppVar.mainForm.label_status.Text = GetDescription();
            }
            get
            {
                return val;
            }
        }
        public static string GetDescription()
        {
            switch (Value)
            {
                case Ready: return "Ready";
                case Busy: return "Busy";
                case Error: return "Error";
                default: return string.Empty;
            }
        }
    }
    public static class PortCOM
    {
        private static SerialPortPhantom portPh;
        private static SerialPort portRl;
        public static bool Real;
        public static uint BaudRate
        {
            set
            {
                if (Real)
                {
                    portRl.BaudRate = (int)value;
                }
                else
                {
                    portPh.BaudRate = (int)value;
                }
            }
            get
            {
                return (uint)(Real ? portRl.BaudRate : portPh.BaudRate);
            }
        }
        public static string Name
        {
            set
            {
                if (Real)
                {
                    portRl.PortName = value;
                }
                else
                {
                    portPh.PortName = value;
                }
            }
            get
            {
                return Real ? portRl.PortName : portPh.PortName;
            }
        }
        public static uint WriteTimeout
        {
            set
            {
                if (Real)
                {
                    portRl.WriteTimeout = (int)value;
                }
                else
                {
                    portPh.WriteTimeout = (int)value;
                }
            }
            get
            {
                return (uint)(Real ? portRl.WriteTimeout : portPh.WriteTimeout);
            }
        }
        public static uint ReadTimeout
        {
            set
            {
                if (Real)
                {
                    portRl.ReadTimeout = (int)value;
                }
                else
                {
                    portPh.ReadTimeout = (int)value;
                }
            }
            get
            {
                return (uint)(Real ? portRl.ReadTimeout : portPh.ReadTimeout);
            }
        }
        public static bool RtsEnable
        {
            set
            {
                if (Real)
                {
                    portRl.RtsEnable = value;
                }
                else
                {
                    portPh.RtsEnable = value;
                }
            }
            get
            {
                return Real ? portRl.RtsEnable : portPh.RtsEnable;
            }
        }
        public static bool DtrEnable
        {
            set
            {
                if (Real)
                {
                    portRl.DtrEnable = value;
                }
                else
                {
                    portPh.DtrEnable = value;
                }
            }
            get
            {
                return Real ? portRl.DtrEnable : portPh.DtrEnable;
            }
        }
        public static class State
        {
            public const byte NoPort = 0;
            public const byte Ready = 1;
            public const byte PortClosed = 2;
            public const byte WaitingToWrite = 3;
            public const byte WaitingToRead = 4;
            public const byte Writing = 5;
            public const byte Reading = 6;

            private static byte val;
            public static byte Value
            {
                set
                {
                    val = value;
                    AppVar.mainForm.label_portState.Text = GetDescription();
                    AppVar.Log("Serial Port state changed to " + val.ToString(), false);
                }
                get
                {
                    return val;
                }
            }
            public static string GetDescription()
            {
                switch (Value)
                {
                    case NoPort: return "Serial Port COM not found. Check connection.";
                    case PortClosed: return "Serial Port COM is closed.";
                    case Ready: return "Serial Port COM is opened and ready to write or read.";
                    case WaitingToWrite: return "Serial Port COM is awaiting for write.";
                    case WaitingToRead: return "Serial Port COM is awaiting for read.";
                    case Writing: return "Serial Port COM is written to.";
                    case Reading: return "Serial Port COM is read from.";
                    default: return string.Empty;
                }
            }
        }
        public static void Initialize(string pName, uint bRate)
        {
            portPh = new SerialPortPhantom();
            portRl = new SerialPort();
            Real = true;
            for(int i = 0; i < 2; i++)
            {
                RtsEnable = true;
                DtrEnable = true;
                Name = pName;
                BaudRate = bRate;
                WriteTimeout = 100;
                ReadTimeout = 100;
                Real = !Real;
            }
        }
        public static void Open()
        {
            if (Real)
            {
                if (portRl != null)
                {
                    if (!portRl.IsOpen)
                    {
                        try
                        {
                            portRl.Open();
                            MessageBox.Show("Port COM successfully opened.");
                            AppVar.mainForm.connectToolStripMenuItem.Text = "Disconnect";
                            AppVar.mainForm.testToolStripMenuItem.Enabled = true;
                            State.Value = State.Ready;
                        }
                        catch (Exception)
                        {
                            State.Value = State.NoPort;
                            AppVar.mainForm.appLog1.Add("Connecting to Serial Port failed", true);
                        }
                    }
                }
                else
                {
                    State.Value = State.NoPort;
                }
            }
            else
            {
                if (portPh != null)
                {
                    if (!portPh.IsOpen)
                    {
                        try
                        {
                            portPh.Open();
                            MessageBox.Show("Port COM successfully opened.");
                            AppVar.mainForm.connectToolStripMenuItem.Text = "Disconnect";
                            AppVar.mainForm.testToolStripMenuItem.Enabled = true;
                            State.Value = State.Ready;
                        }
                        catch (Exception)
                        {
                            State.Value = State.NoPort;
                            AppVar.mainForm.appLog1.Add("Connecting to Serial Port failed", true);
                        }
                    }
                }
                else
                {
                    State.Value = State.NoPort;
                }
            }
            if(State.Value == State.NoPort)
            {
                MessageBox.Show("Port COM not found!");
            }
        }
        public static void Close()
        {
            if (Real)
            {
                if (portRl != null)
                {
                    if (portRl.IsOpen)
                    {
                        portRl.Close();
                        AppVar.mainForm.connectToolStripMenuItem.Text = "Connect";
                        AppVar.mainForm.testToolStripMenuItem.Enabled = false;
                    }
                    State.Value = State.PortClosed;
                }
                State.Value = State.NoPort;
            }
            else
            {
                if (portPh != null)
                {
                    if (portPh.IsOpen)
                    {
                        portPh.Close();
                        AppVar.mainForm.connectToolStripMenuItem.Text = "Connect";
                        AppVar.mainForm.testToolStripMenuItem.Enabled = false;
                    }
                    State.Value = State.PortClosed;
                }
                State.Value = State.NoPort;
            }
        }

        public static void WriteLine(string val)
        {
            try
            {
                if (Real)
                {
                    portRl.Write(val);
                }
                else
                {
                    portPh.Write(val);
                }
            }
            catch (Exception)
            {
                State.Value = State.NoPort;
                throw new Exception("Write to port failed.");
            }
        }
        public static string ReadAll()
        {
            string val = string.Empty;
            try
            {
                if (Real)
                {
                    val = portRl.ReadExisting();
                }
                else
                {
                    val = portPh.ReadExisting();
                }
            }
            catch (Exception)
            {
                State.Value = State.NoPort;
                val = string.Empty;
            }
            return val;
        }
        public static void Clear()
        {
            if (Real)
            {
                portRl.DiscardInBuffer();
                portRl.DiscardOutBuffer();
            }
            else
            {
                portPh.DiscardInBuffer();
                portPh.DiscardOutBuffer();
            }
        }
    }
}
