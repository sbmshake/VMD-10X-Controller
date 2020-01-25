using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMD_10X_Controller.Modes
{
    public partial class Mode_Scan2D : UserControl
    {
        private byte axisPrimary;
        private byte axisSecondary;
        public Mode_Scan2D()
        {
            InitializeComponent();
        }

        private void Mode_Scan2D_Load(object sender, EventArgs e)
        {
            comboBox_pAxis.Items.Clear();
            comboBox_pAxis.Items.AddRange(VMD.Axis.NameCollection);
            comboBox_pAxis.SelectedIndex = 0;
            comboBox_sAxis.SelectedIndex = 0;
            comboBox_pDir.SelectedIndex = 0;
            comboBox_sDir.SelectedIndex = 0;
            string[] dir =
            {
                "CCW",
                "CW"
            };
            comboBox_pDir.Items.Clear();
            comboBox_pDir.Items.AddRange(dir);
            comboBox_pDir.SelectedIndex = 0;
            comboBox_sDir.Items.Clear();
            comboBox_sDir.Items.AddRange(dir);
            comboBox_sDir.SelectedIndex = 0;

            speedPicker_p.Minimum = 0;
            speedPicker_p.Maximum = 1570;
            speedPicker_p.Value = (int)(Math.PI / 4 * 1000);
            speedPicker_p.Coefficient = 0.180 / Math.PI;
            speedPicker_p.Suffix = (char)176 + "/s";
            speedPicker_p.WarningLevel1 = 0.4;
            speedPicker_p.WarningLevel2 = 0.8;

            speedPicker_s.Minimum = 0;
            speedPicker_s.Maximum = 1570;
            speedPicker_s.Value = (int)(Math.PI / 4 * 1000);
            speedPicker_s.Coefficient = 0.180 / Math.PI;
            speedPicker_s.Suffix = (char)176 + "/s";
            speedPicker_s.WarningLevel1 = 0.4;
            speedPicker_s.WarningLevel2 = 0.8;
        }

        private void comboBox_primaryAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            var axisList = VMD.Axis.NameCollection.ToList();
            axisList.RemoveAt(comboBox_pAxis.SelectedIndex);
            comboBox_sAxis.Items.Clear();
            comboBox_sAxis.Items.AddRange(axisList.ToArray());
            comboBox_sAxis.SelectedIndex = 0;
            axisPrimary = VMD.Axis.GetAxisNumber(comboBox_pAxis.SelectedItem.ToString());
            if (axisPrimary == VMD.Axis.LowerVertical)
            {
                SetDistanceInputAngle(ud_pAxisDist, label_pAxisDist);
                SetDistanceInputAngle(ud_pAxisBetween, label_pAxisBetween);
            }
            else
            {
                SetDistanceInputLength(ud_pAxisDist, label_pAxisDist);
                SetDistanceInputLength(ud_pAxisBetween, label_pAxisBetween);
            }
        }
        private void comboBox_sAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            axisSecondary = VMD.Axis.GetAxisNumber(comboBox_sAxis.SelectedItem.ToString());
            if (axisSecondary == VMD.Axis.LowerVertical)
            {
                SetDistanceInputAngle(ud_sAxisDist, label_sAxisDist);
            }
            else
            {
                SetDistanceInputLength(ud_sAxisDist, label_sAxisDist);
            }
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            VMD.BasicMoves.Scan(
                axisPrimary,
                (byte)comboBox_pDir.SelectedIndex,
                (ushort)speedPicker_p.Value,
                VMD.DistToSteps(axisPrimary, decimal.ToInt32(ud_pAxisDist.Value)),
                VMD.DistToSteps(axisPrimary, decimal.ToInt32(ud_pAxisBetween.Value)),
                axisSecondary,
                (byte)comboBox_sDir.SelectedIndex,
                (ushort)speedPicker_p.Value,
                VMD.DistToSteps(axisSecondary, decimal.ToInt32(ud_sAxisDist.Value)),
                1000
                );
        }
        private void SetDistanceInputLength(NumericUpDown ud, Label unit)
        {
            unit.Text = "mm";
            ud.Maximum = 50;
            ud.Minimum = 0;
        }
        private void SetDistanceInputAngle(NumericUpDown ud, Label unit)
        {
            unit.Text = string.Empty + (char)176;
            ud.Maximum = 360;
            ud.Minimum = 0;
        }
    }
}
