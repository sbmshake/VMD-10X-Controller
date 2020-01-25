using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMD_10X_Controller
{
    public partial class AppLog : UserControl
    {
        private bool min;
        public AppLog()
        {
            InitializeComponent();
        }
        private void AppLog_Load(object sender, EventArgs e)
        {
            min = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!min)
            {
                this.MinimumSize = new Size(0, 25);
                this.Height = 25;
            }
            else
            {
                this.MinimumSize = new Size(0, 0);
                this.Height = 100;
            }
            min = !min;
        }
        public void Add(string message, bool important)
        {
            if(important || !checkBox_high.Checked)
            {
                richTextBox1.AppendText("[" + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "] " + message + "\n");
            }
        }
    }
}
