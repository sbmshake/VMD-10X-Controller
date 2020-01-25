using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMD_10X_Controller
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            ud_baudRate.Value = PortCOM.BaudRate;
            ud_write.Value = PortCOM.WriteTimeout;
            ud_read.Value = PortCOM.ReadTimeout;
            checkBox_rts.Checked = PortCOM.RtsEnable;
            checkBox_dtr.Checked = PortCOM.DtrEnable;
            comboBox_portName.Items.Clear();
            comboBox_portName.Items.AddRange(SerialPort.GetPortNames());
            comboBox_portName.SelectedIndex = 0;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            PortCOM.Initialize(comboBox_portName.SelectedItem.ToString(), decimal.ToUInt32(ud_baudRate.Value));
            PortCOM.WriteTimeout = decimal.ToUInt16(ud_write.Value);
            PortCOM.ReadTimeout = decimal.ToUInt16(ud_read.Value);
            PortCOM.RtsEnable = checkBox_rts.Checked;
            PortCOM.RtsEnable = checkBox_rts.Checked;
            this.Close();
        }
    }
}
