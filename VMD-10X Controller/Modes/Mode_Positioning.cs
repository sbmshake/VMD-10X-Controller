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
    public partial class Mode_Positioning : UserControl
    {
        private byte axis;
        public Mode_Positioning()
        {
            InitializeComponent();
        }
        private void Mode_Positioning_Load(object sender, EventArgs e)
        {
            comboBox_axis.Items.Clear();
            comboBox_axis.Items.AddRange(VMD.Axis.NameCollection);
            comboBox_axis.SelectedIndex = 0;
            speedPicker.Minimum = 0;
            speedPicker.Maximum = 1570;
            speedPicker.Value = (int)(Math.PI / 4 * 1000);
            speedPicker.Coefficient = 0.180 / Math.PI;
            speedPicker.Suffix = (char)176 + "/s";
            speedPicker.WarningLevel1 = 0.4;
            speedPicker.WarningLevel2 = 0.8;
        }

        private void upDownCounter_distance_ValueChanged(object sender, EventArgs e)
        {
            upDownCounter_distance.Value = Math.Round(upDownCounter_distance.Value, 1);
        }

        private void comboBox_axis_SelectedIndexChanged(object sender, EventArgs e)
        {
            axis = VMD.Axis.GetAxisNumber(comboBox_axis.SelectedItem.ToString());
            if(axis == VMD.Axis.LowerVertical)
            {
                SetDistanceInputAngle(upDownCounter_distance, label_units);
            }
            else
            {
                SetDistanceInputLength(upDownCounter_distance, label_units);
            }
        }
        private void button_CW_Click(object sender, EventArgs e)
        {
            VMD.BasicMoves.Move(
                axis,
                VMD.Direction.CW,
                VMD.DistToSteps(axis, decimal.ToDouble(upDownCounter_distance.Value)),
                (ushort)speedPicker.Value,
                1000
                );
        }

        private void button_CCW_Click(object sender, EventArgs e)
        {
            VMD.BasicMoves.Move(
                axis,
                VMD.Direction.CCW,
                VMD.DistToSteps(axis, decimal.ToDouble(upDownCounter_distance.Value)),
                (ushort)speedPicker.Value,
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

        private void button_setBase_Click(object sender, EventArgs e)
        {
            VMD.BasicMoves.SetBase();
        }

        private void button_GotoBase_Click(object sender, EventArgs e)
        {
            VMD.BasicMoves.GotoBase();
        }
    }
}
