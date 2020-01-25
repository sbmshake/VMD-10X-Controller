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
    public partial class SpeedPicker : UserControl
    {
        public int Maximum
        {
            set
            {
                trackBar.Maximum = value;
                UpdateControl();
            }
            get
            {
                return trackBar.Maximum;
            }
        }
        public int Minimum
        {
            set
            {
                trackBar.Minimum = value;
                UpdateControl();
            }
            get
            {
                return trackBar.Minimum;
            }
        }
        public int Value
        {
            set
            {
                trackBar.Value = value;
                UpdateControl();
            }
            get
            {
                return trackBar.Value;
            }
        }
        private double coef;
        public double Coefficient
        {
            set
            {
                coef = value;
                UpdateControl();
            }
            get
            {
                return coef;
            }
        }
        string suffix;
        public string Suffix
        {
            set
            {
                suffix = value;
                UpdateControl();
            }
            get
            {
                return suffix;
            }
        }
        private double warning1;
        public double WarningLevel1
        {
            set
            {
                warning1 = value;
                UpdateControl();
            }
            get
            {
                return warning1;
            }
        }
        private double warning2;
        public double WarningLevel2
        {
            set
            {
                warning2 = value;
                UpdateControl();
            }
            get
            {
                return warning2;
            }
        }
        public SpeedPicker()
        {
            InitializeComponent();
        }
        private void SpeedPicker_Load(object sender, EventArgs e)
        {
            trackBar.Minimum = 0;
            trackBar.Maximum = 1;
            trackBar.Value = 0;
            coef = 1;
            suffix = string.Empty;
            warning1 = 0;
            warning2 = 0;
            UpdateControl();
        }
        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            UpdateControl();
        }
        private void UpdateControl()
        {
            label.Text = (Value * Coefficient).ToString("#0.0") + Suffix;
            if (Value >= WarningLevel1 * Maximum)
            {
                if (Value >= WarningLevel2 * Maximum)
                {

                    panel.BackColor = Color.FromArgb(255, (int)(255 * (1 - ((1.0 * Value / Maximum) - WarningLevel2) * (1.0 / (1 - WarningLevel2)))), 0);
                }
                else
                {
                    panel.BackColor = Color.FromArgb((int)(255 * (((1.0 * Value / Maximum) - WarningLevel1) * (1.0 / (WarningLevel2 - WarningLevel1)))), 255, 0);
                }
            }
            else
            {
                panel.BackColor = Color.FromArgb(0, 255, 0);
            }
        }
    }
}
