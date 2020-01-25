using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace VMD_10X_Controller
{
    public partial class MainForm : Form
    {
        private OptionsForm optionsForm;
        private StreamWriter positionFile;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppVar.Initialize(this);
            VMD.Initialize();
            optionsForm = new OptionsForm();
            menu_mode_positioning_Click(null, null);
            textBox_path.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\out01.csv";
            VMD.SampleTime = 1000.0 / decimal.ToDouble(ud_samplingFreq.Value);
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            PortCOM.Open();
            AppVar.Log("Application initialized successfully", true);
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) => new OptionsForm().Show();

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PortCOM.Close();
            optionsForm.Close();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VMD.Ready(VMD.Axis.LowerHorizontal);
        }
        private void HideAllModes()
        {
            mode_Positioning1.Hide();
            mode_Scan2D1.Hide();
        }
        private void menu_mode_positioning_Click(object sender, EventArgs e)
        {
            ProgrammingMode.Value = ProgrammingMode.Positioning;
            HideAllModes();
            mode_Positioning1.Show();
        }

        private void menu_mode_scan_Click(object sender, EventArgs e)
        {
            ProgrammingMode.Value = ProgrammingMode.Scan;
            HideAllModes();
            mode_Scan2D1.Show();
        }

        private void menu_mode_simplified_Click(object sender, EventArgs e)
        {
            ProgrammingMode.Value = ProgrammingMode.Simplified;
        }

        private void menu_mode_professional_Click(object sender, EventArgs e)
        {
            ProgrammingMode.Value = ProgrammingMode.Professional;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(PortCOM.State.Value == PortCOM.State.NoPort || PortCOM.State.Value == PortCOM.State.PortClosed)
            {
                PortCOM.Open();
            }
            else
            {
                PortCOM.Close();
            }
        }
        private void simulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortCOM.Close();
            PortCOM.Real = false;
            PortCOM.Open();
        }

        private void menu_file_open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void menu_file_SaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string docPath = openFileDialog1.FileName;
            using (StreamReader outputFile = new StreamReader(docPath))
            {
                //richTextBox_code.Text = outputFile.ReadToEnd();
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string docPath = saveFileDialog1.FileName;
            using (StreamWriter outputFile = new StreamWriter(docPath))
            {
                //foreach (string line in richTextBox_code.Lines)
                    //outputFile.WriteLine(line);
            }
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application designed and programmed for educational purposes only.\n" +
                "Created for specially for 4-axis positioner control.\n\n" +
                "Code:\t\t\tMateusz Śliwiński\n" +
                "\t\t\tTomasz Szydłowski\n" +
                "Design:\t\t\tMateusz Śliwiński\n" +
                "Consulting and mentoring:\tPaweł Kustroń\n\n" +
                "Version: 1.1\n" +
                "Date: 01/2020",
                "About");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            VMD.SampleTime = 1000.0 / decimal.ToDouble(ud_samplingFreq.Value);
        }
        public void WriteToPortLog(string text, bool response)
        {
            Color bk, sel;
            bk = response ? Color.LightGray : Color.DodgerBlue;
            sel = response ? Color.DarkSlateGray : Color.White;
            serialPortLog.SelectionStart = AppVar.mainForm.serialPortLog.TextLength;
            serialPortLog.SelectionLength = 0;
            serialPortLog.SelectionBackColor = bk;
            serialPortLog.SelectionColor = sel;
            serialPortLog.AppendText(text + "\n");
            serialPortLog.SelectionColor = AppVar.mainForm.serialPortLog.ForeColor;
            serialPortLog.Select(serialPortLog.Text.Length - 1, 0);
            serialPortLog.ScrollToCaret();
        }

        private void saveOutputFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            textBox_path.Text = saveOutputFileDialog.FileName;
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            saveOutputFileDialog.ShowDialog();
        }

        private void checkBox_recording_CheckedChanged(object sender, EventArgs e)
        {
            long timeLast = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            bool recording = checkBox_recording.Checked;
            if (recording)
            {
                VMD.Recording = true;
                Task recordTask = new Task(() =>
                {
                    try
                    {
                        do
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                long timeCurrent = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                                if (timeCurrent - timeLast >= 500)
                                {
                                    timeLast = timeCurrent;
                                    panel_record.Visible = !panel_record.Visible;
                                }
                                recording = checkBox_recording.Checked;
                            });
                        } while (recording);
                    }
                    catch { }
                });
                recordTask.Start();
            }
            else
            {
                panel_record.Visible = false;
                VMD.Recording = false;
            }
        }
        public void OpenPositionFile()
        {
            positionFile = new StreamWriter(textBox_path.Text);
            positionFile.WriteLine(
                "Time [ms]" + "," +
                VMD.Axis.GetDescription(0) + "," +
                VMD.Axis.GetDescription(1) + "," +
                VMD.Axis.GetDescription(2) + "," +
                VMD.Axis.GetDescription(3));
        }
        public void ClosePositionFile()
        {
            positionFile.Close();
            positionFile.Dispose();
        }
        public void SavePositionTask(List<int[]> position)
        {
            try
            {
                StreamWriter fileStream = null;
                int count = 0;
                Invoke((MethodInvoker)delegate
                {
                    count = position.Count;
                    fileStream = positionFile;
                });
                while(count > 0)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        if (fileStream != null)
                        {
                            /*string temp = string.Empty;
                            for(int i = 0; i < count; i++)
                            {
                                temp += position[0][0].ToString() + "," +
                                        position[0][1].ToString() + "," +
                                        position[0][2].ToString() + "," +
                                        position[0][3].ToString() + "\n";
                            }
                            fileStream.Write(temp);*/
                            positionFile.WriteLine(
                            position[0][0].ToString() + "," +
                            position[0][1].ToString() + "," +
                            position[0][2].ToString() + "," +
                            position[0][3].ToString()
                            );
                            position.RemoveAt(0);
                        }
                        count = position.Count;
                    });
                }
            }
            catch { }
        }
    }
}
