namespace VMD_10X_Controller.Modes
{
    partial class Mode_Positioning
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_dist = new System.Windows.Forms.Label();
            this.upDownCounter_distance = new System.Windows.Forms.NumericUpDown();
            this.button_CCW = new System.Windows.Forms.Button();
            this.button_CW = new System.Windows.Forms.Button();
            this.label_units = new System.Windows.Forms.Label();
            this.groupBox_axis = new System.Windows.Forms.GroupBox();
            this.comboBox_axis = new System.Windows.Forms.ComboBox();
            this.button_setBase = new System.Windows.Forms.Button();
            this.button_GotoBase = new System.Windows.Forms.Button();
            this.speedPicker = new VMD_10X_Controller.SpeedPicker();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCounter_distance)).BeginInit();
            this.groupBox_axis.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_dist
            // 
            this.label_dist.Location = new System.Drawing.Point(4, 48);
            this.label_dist.Name = "label_dist";
            this.label_dist.Size = new System.Drawing.Size(49, 13);
            this.label_dist.TabIndex = 19;
            this.label_dist.Text = "Distance:";
            this.label_dist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // upDownCounter_distance
            // 
            this.upDownCounter_distance.DecimalPlaces = 1;
            this.upDownCounter_distance.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.upDownCounter_distance.Location = new System.Drawing.Point(59, 46);
            this.upDownCounter_distance.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.upDownCounter_distance.Name = "upDownCounter_distance";
            this.upDownCounter_distance.Size = new System.Drawing.Size(46, 20);
            this.upDownCounter_distance.TabIndex = 16;
            this.upDownCounter_distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.upDownCounter_distance.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.upDownCounter_distance.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDownCounter_distance.ValueChanged += new System.EventHandler(this.upDownCounter_distance_ValueChanged);
            // 
            // button_CCW
            // 
            this.button_CCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_CCW.Location = new System.Drawing.Point(0, 3);
            this.button_CCW.Name = "button_CCW";
            this.button_CCW.Size = new System.Drawing.Size(65, 27);
            this.button_CCW.TabIndex = 14;
            this.button_CCW.Text = "< CCW <";
            this.button_CCW.UseVisualStyleBackColor = true;
            this.button_CCW.Click += new System.EventHandler(this.button_CCW_Click);
            // 
            // button_CW
            // 
            this.button_CW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_CW.Location = new System.Drawing.Point(75, 3);
            this.button_CW.Name = "button_CW";
            this.button_CW.Size = new System.Drawing.Size(65, 27);
            this.button_CW.TabIndex = 13;
            this.button_CW.Text = "> CW >";
            this.button_CW.UseVisualStyleBackColor = true;
            this.button_CW.Click += new System.EventHandler(this.button_CW_Click);
            // 
            // label_units
            // 
            this.label_units.AutoSize = true;
            this.label_units.Location = new System.Drawing.Point(104, 48);
            this.label_units.Name = "label_units";
            this.label_units.Size = new System.Drawing.Size(23, 13);
            this.label_units.TabIndex = 29;
            this.label_units.Text = "mm";
            this.label_units.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox_axis
            // 
            this.groupBox_axis.Controls.Add(this.speedPicker);
            this.groupBox_axis.Controls.Add(this.comboBox_axis);
            this.groupBox_axis.Controls.Add(this.upDownCounter_distance);
            this.groupBox_axis.Controls.Add(this.label_dist);
            this.groupBox_axis.Controls.Add(this.label_units);
            this.groupBox_axis.Location = new System.Drawing.Point(3, 36);
            this.groupBox_axis.Name = "groupBox_axis";
            this.groupBox_axis.Size = new System.Drawing.Size(133, 135);
            this.groupBox_axis.TabIndex = 30;
            this.groupBox_axis.TabStop = false;
            this.groupBox_axis.Text = "Axis";
            // 
            // comboBox_axis
            // 
            this.comboBox_axis.FormattingEnabled = true;
            this.comboBox_axis.Items.AddRange(new object[] {
            "Upper Horizontal",
            "Upper Vertical",
            "Lower Horizontal",
            "Lower Vertical"});
            this.comboBox_axis.Location = new System.Drawing.Point(6, 19);
            this.comboBox_axis.Name = "comboBox_axis";
            this.comboBox_axis.Size = new System.Drawing.Size(122, 21);
            this.comboBox_axis.TabIndex = 1;
            this.comboBox_axis.SelectedIndexChanged += new System.EventHandler(this.comboBox_axis_SelectedIndexChanged);
            // 
            // button_setBase
            // 
            this.button_setBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_setBase.Location = new System.Drawing.Point(0, 266);
            this.button_setBase.Name = "button_setBase";
            this.button_setBase.Size = new System.Drawing.Size(140, 25);
            this.button_setBase.TabIndex = 33;
            this.button_setBase.Text = "Set Base";
            this.button_setBase.UseVisualStyleBackColor = true;
            this.button_setBase.Click += new System.EventHandler(this.button_setBase_Click);
            // 
            // button_GotoBase
            // 
            this.button_GotoBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_GotoBase.Location = new System.Drawing.Point(0, 291);
            this.button_GotoBase.Name = "button_GotoBase";
            this.button_GotoBase.Size = new System.Drawing.Size(140, 25);
            this.button_GotoBase.TabIndex = 32;
            this.button_GotoBase.Text = "Go to Base";
            this.button_GotoBase.UseVisualStyleBackColor = true;
            this.button_GotoBase.Click += new System.EventHandler(this.button_GotoBase_Click);
            // 
            // speedPicker
            // 
            this.speedPicker.AutoSize = true;
            this.speedPicker.Coefficient = 1D;
            this.speedPicker.Location = new System.Drawing.Point(5, 79);
            this.speedPicker.Maximum = 1;
            this.speedPicker.Minimum = 0;
            this.speedPicker.Name = "speedPicker";
            this.speedPicker.Size = new System.Drawing.Size(123, 50);
            this.speedPicker.Suffix = "";
            this.speedPicker.TabIndex = 30;
            this.speedPicker.Value = 0;
            this.speedPicker.WarningLevel1 = 0D;
            this.speedPicker.WarningLevel2 = 0D;
            // 
            // Mode_Positioning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_setBase);
            this.Controls.Add(this.button_GotoBase);
            this.Controls.Add(this.groupBox_axis);
            this.Controls.Add(this.button_CCW);
            this.Controls.Add(this.button_CW);
            this.DoubleBuffered = true;
            this.Name = "Mode_Positioning";
            this.Size = new System.Drawing.Size(140, 316);
            this.Load += new System.EventHandler(this.Mode_Positioning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDownCounter_distance)).EndInit();
            this.groupBox_axis.ResumeLayout(false);
            this.groupBox_axis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_dist;
        private System.Windows.Forms.NumericUpDown upDownCounter_distance;
        private System.Windows.Forms.Button button_CCW;
        private System.Windows.Forms.Button button_CW;
        private System.Windows.Forms.Label label_units;
        private System.Windows.Forms.GroupBox groupBox_axis;
        private System.Windows.Forms.Button button_setBase;
        private System.Windows.Forms.Button button_GotoBase;
        private System.Windows.Forms.ComboBox comboBox_axis;
        private SpeedPicker speedPicker;
    }
}
