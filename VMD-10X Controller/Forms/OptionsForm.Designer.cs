namespace VMD_10X_Controller
{
    partial class OptionsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_PortInfo = new System.Windows.Forms.GroupBox();
            this.ud_baudRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_programming = new System.Windows.Forms.GroupBox();
            this.checkBox_dtr = new System.Windows.Forms.CheckBox();
            this.checkBox_rts = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ud_read = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ud_write = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.comboBox_portName = new System.Windows.Forms.ComboBox();
            this.groupBox_PortInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_baudRate)).BeginInit();
            this.groupBox_programming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_read)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_write)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_PortInfo
            // 
            this.groupBox_PortInfo.Controls.Add(this.comboBox_portName);
            this.groupBox_PortInfo.Controls.Add(this.ud_baudRate);
            this.groupBox_PortInfo.Controls.Add(this.label2);
            this.groupBox_PortInfo.Controls.Add(this.label1);
            this.groupBox_PortInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBox_PortInfo.Name = "groupBox_PortInfo";
            this.groupBox_PortInfo.Size = new System.Drawing.Size(159, 76);
            this.groupBox_PortInfo.TabIndex = 0;
            this.groupBox_PortInfo.TabStop = false;
            this.groupBox_PortInfo.Text = "Basic";
            // 
            // ud_baudRate
            // 
            this.ud_baudRate.Location = new System.Drawing.Point(72, 45);
            this.ud_baudRate.Maximum = new decimal(new int[] {
            524288,
            0,
            0,
            0});
            this.ud_baudRate.Name = "ud_baudRate";
            this.ud_baudRate.Size = new System.Drawing.Size(81, 20);
            this.ud_baudRate.TabIndex = 3;
            this.ud_baudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ud_baudRate.Value = new decimal(new int[] {
            460800,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // groupBox_programming
            // 
            this.groupBox_programming.Controls.Add(this.checkBox_dtr);
            this.groupBox_programming.Controls.Add(this.checkBox_rts);
            this.groupBox_programming.Controls.Add(this.label6);
            this.groupBox_programming.Controls.Add(this.label5);
            this.groupBox_programming.Controls.Add(this.ud_read);
            this.groupBox_programming.Controls.Add(this.label4);
            this.groupBox_programming.Controls.Add(this.ud_write);
            this.groupBox_programming.Controls.Add(this.label3);
            this.groupBox_programming.Location = new System.Drawing.Point(12, 94);
            this.groupBox_programming.Name = "groupBox_programming";
            this.groupBox_programming.Size = new System.Drawing.Size(159, 122);
            this.groupBox_programming.TabIndex = 1;
            this.groupBox_programming.TabStop = false;
            this.groupBox_programming.Text = "Advanced";
            // 
            // checkBox_dtr
            // 
            this.checkBox_dtr.AutoSize = true;
            this.checkBox_dtr.Location = new System.Drawing.Point(138, 106);
            this.checkBox_dtr.Name = "checkBox_dtr";
            this.checkBox_dtr.Size = new System.Drawing.Size(15, 14);
            this.checkBox_dtr.TabIndex = 11;
            this.checkBox_dtr.UseVisualStyleBackColor = true;
            // 
            // checkBox_rts
            // 
            this.checkBox_rts.AutoSize = true;
            this.checkBox_rts.Location = new System.Drawing.Point(138, 80);
            this.checkBox_rts.Name = "checkBox_rts";
            this.checkBox_rts.Size = new System.Drawing.Size(15, 14);
            this.checkBox_rts.TabIndex = 10;
            this.checkBox_rts.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data Terminal Ready";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Request To Send";
            // 
            // ud_read
            // 
            this.ud_read.Location = new System.Drawing.Point(105, 51);
            this.ud_read.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ud_read.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ud_read.Name = "ud_read";
            this.ud_read.Size = new System.Drawing.Size(48, 20);
            this.ud_read.TabIndex = 7;
            this.ud_read.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ud_read.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Read Timeout [ms]";
            // 
            // ud_write
            // 
            this.ud_write.Location = new System.Drawing.Point(105, 24);
            this.ud_write.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ud_write.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ud_write.Name = "ud_write";
            this.ud_write.Size = new System.Drawing.Size(48, 20);
            this.ud_write.TabIndex = 5;
            this.ud_write.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ud_write.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Write Timeout [ms]";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(103, 222);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(68, 26);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(15, 222);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(68, 26);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // comboBox_portName
            // 
            this.comboBox_portName.FormattingEnabled = true;
            this.comboBox_portName.Location = new System.Drawing.Point(72, 18);
            this.comboBox_portName.Name = "comboBox_portName";
            this.comboBox_portName.Size = new System.Drawing.Size(81, 21);
            this.comboBox_portName.TabIndex = 4;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 260);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.groupBox_programming);
            this.Controls.Add(this.groupBox_PortInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.groupBox_PortInfo.ResumeLayout(false);
            this.groupBox_PortInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_baudRate)).EndInit();
            this.groupBox_programming.ResumeLayout(false);
            this.groupBox_programming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_read)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_write)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_PortInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_programming;
        private System.Windows.Forms.NumericUpDown ud_baudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ud_read;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ud_write;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_dtr;
        private System.Windows.Forms.CheckBox checkBox_rts;
        private System.Windows.Forms.ComboBox comboBox_portName;
    }
}