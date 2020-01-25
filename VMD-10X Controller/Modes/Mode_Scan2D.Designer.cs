namespace VMD_10X_Controller.Modes
{
    partial class Mode_Scan2D
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
            this.comboBox_pAxis = new System.Windows.Forms.ComboBox();
            this.groupBox_primaryAxis = new System.Windows.Forms.GroupBox();
            this.speedPicker_p = new VMD_10X_Controller.SpeedPicker();
            this.label_pAxisBetween = new System.Windows.Forms.Label();
            this.label_pBetweenName = new System.Windows.Forms.Label();
            this.ud_pAxisBetween = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_pDir = new System.Windows.Forms.ComboBox();
            this.label_pAxisDist = new System.Windows.Forms.Label();
            this.label_pDistName = new System.Windows.Forms.Label();
            this.ud_pAxisDist = new System.Windows.Forms.NumericUpDown();
            this.groupBox_secondaryAxis = new System.Windows.Forms.GroupBox();
            this.comboBox_sDir = new System.Windows.Forms.ComboBox();
            this.speedPicker_s = new VMD_10X_Controller.SpeedPicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_sAxis = new System.Windows.Forms.ComboBox();
            this.label_sAxisDist = new System.Windows.Forms.Label();
            this.label_sDistName = new System.Windows.Forms.Label();
            this.ud_sAxisDist = new System.Windows.Forms.NumericUpDown();
            this.button_run = new System.Windows.Forms.Button();
            this.groupBox_primaryAxis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_pAxisBetween)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_pAxisDist)).BeginInit();
            this.groupBox_secondaryAxis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_sAxisDist)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_pAxis
            // 
            this.comboBox_pAxis.FormattingEnabled = true;
            this.comboBox_pAxis.Items.AddRange(new object[] {
            "Upper Horizontal",
            "Upper Vertical",
            "Lower Horizontal",
            "Lower Vertical"});
            this.comboBox_pAxis.Location = new System.Drawing.Point(6, 19);
            this.comboBox_pAxis.Name = "comboBox_pAxis";
            this.comboBox_pAxis.Size = new System.Drawing.Size(122, 21);
            this.comboBox_pAxis.TabIndex = 0;
            this.comboBox_pAxis.SelectedIndexChanged += new System.EventHandler(this.comboBox_primaryAxis_SelectedIndexChanged);
            // 
            // groupBox_primaryAxis
            // 
            this.groupBox_primaryAxis.Controls.Add(this.speedPicker_p);
            this.groupBox_primaryAxis.Controls.Add(this.label_pAxisBetween);
            this.groupBox_primaryAxis.Controls.Add(this.label_pBetweenName);
            this.groupBox_primaryAxis.Controls.Add(this.ud_pAxisBetween);
            this.groupBox_primaryAxis.Controls.Add(this.label4);
            this.groupBox_primaryAxis.Controls.Add(this.comboBox_pDir);
            this.groupBox_primaryAxis.Controls.Add(this.label_pAxisDist);
            this.groupBox_primaryAxis.Controls.Add(this.comboBox_pAxis);
            this.groupBox_primaryAxis.Controls.Add(this.label_pDistName);
            this.groupBox_primaryAxis.Controls.Add(this.ud_pAxisDist);
            this.groupBox_primaryAxis.Location = new System.Drawing.Point(3, 3);
            this.groupBox_primaryAxis.Name = "groupBox_primaryAxis";
            this.groupBox_primaryAxis.Size = new System.Drawing.Size(134, 187);
            this.groupBox_primaryAxis.TabIndex = 2;
            this.groupBox_primaryAxis.TabStop = false;
            this.groupBox_primaryAxis.Text = "Primary Axis";
            // 
            // speedPicker_p
            // 
            this.speedPicker_p.AutoSize = true;
            this.speedPicker_p.Coefficient = 1D;
            this.speedPicker_p.Location = new System.Drawing.Point(6, 100);
            this.speedPicker_p.Maximum = 1;
            this.speedPicker_p.Minimum = 0;
            this.speedPicker_p.Name = "speedPicker_p";
            this.speedPicker_p.Size = new System.Drawing.Size(123, 48);
            this.speedPicker_p.Suffix = "";
            this.speedPicker_p.TabIndex = 42;
            this.speedPicker_p.Value = 0;
            this.speedPicker_p.WarningLevel1 = 0D;
            this.speedPicker_p.WarningLevel2 = 0D;
            // 
            // label_pAxisBetween
            // 
            this.label_pAxisBetween.AutoSize = true;
            this.label_pAxisBetween.Location = new System.Drawing.Point(110, 76);
            this.label_pAxisBetween.Name = "label_pAxisBetween";
            this.label_pAxisBetween.Size = new System.Drawing.Size(23, 13);
            this.label_pAxisBetween.TabIndex = 40;
            this.label_pAxisBetween.Text = "mm";
            this.label_pAxisBetween.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_pBetweenName
            // 
            this.label_pBetweenName.AutoSize = true;
            this.label_pBetweenName.Location = new System.Drawing.Point(3, 76);
            this.label_pBetweenName.Name = "label_pBetweenName";
            this.label_pBetweenName.Size = new System.Drawing.Size(49, 13);
            this.label_pBetweenName.TabIndex = 39;
            this.label_pBetweenName.Text = "Between";
            // 
            // ud_pAxisBetween
            // 
            this.ud_pAxisBetween.DecimalPlaces = 1;
            this.ud_pAxisBetween.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.ud_pAxisBetween.Location = new System.Drawing.Point(58, 74);
            this.ud_pAxisBetween.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ud_pAxisBetween.Name = "ud_pAxisBetween";
            this.ud_pAxisBetween.Size = new System.Drawing.Size(46, 20);
            this.ud_pAxisBetween.TabIndex = 38;
            this.ud_pAxisBetween.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ud_pAxisBetween.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.ud_pAxisBetween.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Direction";
            // 
            // comboBox_pDir
            // 
            this.comboBox_pDir.FormattingEnabled = true;
            this.comboBox_pDir.Items.AddRange(new object[] {
            "CW",
            "CCW"});
            this.comboBox_pDir.Location = new System.Drawing.Point(58, 158);
            this.comboBox_pDir.Name = "comboBox_pDir";
            this.comboBox_pDir.Size = new System.Drawing.Size(70, 21);
            this.comboBox_pDir.TabIndex = 36;
            // 
            // label_pAxisDist
            // 
            this.label_pAxisDist.AutoSize = true;
            this.label_pAxisDist.Location = new System.Drawing.Point(110, 50);
            this.label_pAxisDist.Name = "label_pAxisDist";
            this.label_pAxisDist.Size = new System.Drawing.Size(23, 13);
            this.label_pAxisDist.TabIndex = 32;
            this.label_pAxisDist.Text = "mm";
            this.label_pAxisDist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_pDistName
            // 
            this.label_pDistName.AutoSize = true;
            this.label_pDistName.Location = new System.Drawing.Point(3, 50);
            this.label_pDistName.Name = "label_pDistName";
            this.label_pDistName.Size = new System.Drawing.Size(49, 13);
            this.label_pDistName.TabIndex = 31;
            this.label_pDistName.Text = "Distance";
            // 
            // ud_pAxisDist
            // 
            this.ud_pAxisDist.DecimalPlaces = 1;
            this.ud_pAxisDist.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.ud_pAxisDist.Location = new System.Drawing.Point(58, 48);
            this.ud_pAxisDist.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ud_pAxisDist.Name = "ud_pAxisDist";
            this.ud_pAxisDist.Size = new System.Drawing.Size(46, 20);
            this.ud_pAxisDist.TabIndex = 30;
            this.ud_pAxisDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ud_pAxisDist.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.ud_pAxisDist.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox_secondaryAxis
            // 
            this.groupBox_secondaryAxis.Controls.Add(this.comboBox_sDir);
            this.groupBox_secondaryAxis.Controls.Add(this.speedPicker_s);
            this.groupBox_secondaryAxis.Controls.Add(this.label5);
            this.groupBox_secondaryAxis.Controls.Add(this.comboBox_sAxis);
            this.groupBox_secondaryAxis.Controls.Add(this.label_sAxisDist);
            this.groupBox_secondaryAxis.Controls.Add(this.label_sDistName);
            this.groupBox_secondaryAxis.Controls.Add(this.ud_sAxisDist);
            this.groupBox_secondaryAxis.Location = new System.Drawing.Point(3, 196);
            this.groupBox_secondaryAxis.Name = "groupBox_secondaryAxis";
            this.groupBox_secondaryAxis.Size = new System.Drawing.Size(134, 161);
            this.groupBox_secondaryAxis.TabIndex = 38;
            this.groupBox_secondaryAxis.TabStop = false;
            this.groupBox_secondaryAxis.Text = "Secondary Axis";
            // 
            // comboBox_sDir
            // 
            this.comboBox_sDir.FormattingEnabled = true;
            this.comboBox_sDir.Items.AddRange(new object[] {
            "CW",
            "CCW"});
            this.comboBox_sDir.Location = new System.Drawing.Point(58, 134);
            this.comboBox_sDir.Name = "comboBox_sDir";
            this.comboBox_sDir.Size = new System.Drawing.Size(70, 21);
            this.comboBox_sDir.TabIndex = 38;
            // 
            // speedPicker_s
            // 
            this.speedPicker_s.AutoSize = true;
            this.speedPicker_s.Coefficient = 1D;
            this.speedPicker_s.Location = new System.Drawing.Point(6, 74);
            this.speedPicker_s.Maximum = 1;
            this.speedPicker_s.Minimum = 0;
            this.speedPicker_s.Name = "speedPicker_s";
            this.speedPicker_s.Size = new System.Drawing.Size(123, 48);
            this.speedPicker_s.Suffix = "";
            this.speedPicker_s.TabIndex = 41;
            this.speedPicker_s.Value = 0;
            this.speedPicker_s.WarningLevel1 = 0D;
            this.speedPicker_s.WarningLevel2 = 0D;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Direction";
            // 
            // comboBox_sAxis
            // 
            this.comboBox_sAxis.FormattingEnabled = true;
            this.comboBox_sAxis.Items.AddRange(new object[] {
            "Upper Horizontal",
            "Upper Vertical",
            "Lower Horizontal",
            "Lower Vertical"});
            this.comboBox_sAxis.Location = new System.Drawing.Point(6, 19);
            this.comboBox_sAxis.Name = "comboBox_sAxis";
            this.comboBox_sAxis.Size = new System.Drawing.Size(122, 21);
            this.comboBox_sAxis.TabIndex = 1;
            this.comboBox_sAxis.SelectedIndexChanged += new System.EventHandler(this.comboBox_sAxis_SelectedIndexChanged);
            // 
            // label_sAxisDist
            // 
            this.label_sAxisDist.AutoSize = true;
            this.label_sAxisDist.Location = new System.Drawing.Point(110, 50);
            this.label_sAxisDist.Name = "label_sAxisDist";
            this.label_sAxisDist.Size = new System.Drawing.Size(23, 13);
            this.label_sAxisDist.TabIndex = 32;
            this.label_sAxisDist.Text = "mm";
            this.label_sAxisDist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_sDistName
            // 
            this.label_sDistName.AutoSize = true;
            this.label_sDistName.Location = new System.Drawing.Point(3, 50);
            this.label_sDistName.Name = "label_sDistName";
            this.label_sDistName.Size = new System.Drawing.Size(49, 13);
            this.label_sDistName.TabIndex = 31;
            this.label_sDistName.Text = "Distance";
            // 
            // ud_sAxisDist
            // 
            this.ud_sAxisDist.DecimalPlaces = 1;
            this.ud_sAxisDist.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.ud_sAxisDist.Location = new System.Drawing.Point(58, 48);
            this.ud_sAxisDist.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ud_sAxisDist.Name = "ud_sAxisDist";
            this.ud_sAxisDist.Size = new System.Drawing.Size(46, 20);
            this.ud_sAxisDist.TabIndex = 30;
            this.ud_sAxisDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ud_sAxisDist.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.ud_sAxisDist.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_run
            // 
            this.button_run.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_run.Location = new System.Drawing.Point(0, 363);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(140, 37);
            this.button_run.TabIndex = 39;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // Mode_Scan2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.groupBox_secondaryAxis);
            this.Controls.Add(this.groupBox_primaryAxis);
            this.Name = "Mode_Scan2D";
            this.Size = new System.Drawing.Size(140, 400);
            this.Load += new System.EventHandler(this.Mode_Scan2D_Load);
            this.groupBox_primaryAxis.ResumeLayout(false);
            this.groupBox_primaryAxis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_pAxisBetween)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_pAxisDist)).EndInit();
            this.groupBox_secondaryAxis.ResumeLayout(false);
            this.groupBox_secondaryAxis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_sAxisDist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_pAxis;
        private System.Windows.Forms.GroupBox groupBox_primaryAxis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_pDir;
        private System.Windows.Forms.Label label_pAxisDist;
        private System.Windows.Forms.Label label_pDistName;
        private System.Windows.Forms.NumericUpDown ud_pAxisDist;
        private System.Windows.Forms.GroupBox groupBox_secondaryAxis;
        private System.Windows.Forms.ComboBox comboBox_sDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_sAxis;
        private System.Windows.Forms.Label label_sAxisDist;
        private System.Windows.Forms.Label label_sDistName;
        private System.Windows.Forms.NumericUpDown ud_sAxisDist;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.Label label_pAxisBetween;
        private System.Windows.Forms.Label label_pBetweenName;
        private System.Windows.Forms.NumericUpDown ud_pAxisBetween;
        private SpeedPicker speedPicker_p;
        private SpeedPicker speedPicker_s;
    }
}
