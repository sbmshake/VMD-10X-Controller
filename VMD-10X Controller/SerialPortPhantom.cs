using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VMD_10X_Controller
{

    class SerialPortPhantom : System.IO.Ports.SerialPort
    {
        public new bool IsOpen { set; get; }
        private string inContent;
        private string outContent;
        private int moveLength;
        private bool inMotion;
        private Random rnd;
        public SerialPortPhantom()
        {
            IsOpen = false;
            inContent = string.Empty;
            outContent = string.Empty;
            rnd = new Random();
        }
        public new void Open()
        {
            IsOpen = true;
        }
        public new void Close()
        {
            IsOpen = false;
        }
        public new void Write(string text)
        {
            inContent += text;
            outContent += text + "\0";
            if (text.Contains("P"))
            {
                outContent += rnd.Next(-1000, 1000).ToString() + "\r\n\0";
            }
            if (text.Contains("R"))
            {
                inMotion = true;
                moveLength = 0;
            }
            if (text.Contains("I"))
            {
                if (inMotion)
                {
                    if (moveLength < 3)
                    {
                        outContent += "RUN\r\n\0";
                        moveLength++;
                    }
                    else
                    {
                        inMotion = false;
                        outContent += "RDY\r\n\0";
                    }
                }
                else
                {
                    outContent += "RDY\r\n\0";
                }
            }
        }
        public new string ReadExisting()
        {
            string temp = string.Copy(outContent);
            DiscardOutBuffer();
            return temp;
        }
        public new void DiscardInBuffer()
        {
            inContent = string.Empty;
        }
        public new void DiscardOutBuffer()
        {
            outContent = string.Empty;
        }
    }
}
