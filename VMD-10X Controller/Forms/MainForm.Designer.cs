namespace VMD_10X_Controller
{
    partial class MainForm
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
            this.groupBox_log = new System.Windows.Forms.GroupBox();
            this.groupBox_portState = new System.Windows.Forms.GroupBox();
            this.label_portState = new System.Windows.Forms.Label();
            this.serialPortLog = new System.Windows.Forms.RichTextBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_mode = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_mode_positioning = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_mode_scan = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_mode_simplified = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_mode_professional = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_communication = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.label_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox_code = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_record = new System.Windows.Forms.Panel();
            this.checkBox_recording = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ud_samplingFreq = new System.Windows.Forms.NumericUpDown();
            this.groupBox_mode = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveOutputFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mode_Scan2D1 = new VMD_10X_Controller.Modes.Mode_Scan2D();
            this.mode_Positioning1 = new VMD_10X_Controller.Modes.Mode_Positioning();
            this.appLog1 = new VMD_10X_Controller.AppLog();
            this.groupBox_log.SuspendLayout();
            this.groupBox_portState.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.groupBox_code.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_samplingFreq)).BeginInit();
            this.groupBox_mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_log
            // 
            this.groupBox_log.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_log.Controls.Add(this.groupBox_portState);
            this.groupBox_log.Controls.Add(this.serialPortLog);
            this.groupBox_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_log.Location = new System.Drawing.Point(300, 24);
            this.groupBox_log.Name = "groupBox_log";
            this.groupBox_log.Size = new System.Drawing.Size(134, 415);
            this.groupBox_log.TabIndex = 0;
            this.groupBox_log.TabStop = false;
            this.groupBox_log.Text = "Serial Port Log";
            // 
            // groupBox_portState
            // 
            this.groupBox_portState.Controls.Add(this.label_portState);
            this.groupBox_portState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_portState.Location = new System.Drawing.Point(3, 300);
            this.groupBox_portState.Name = "groupBox_portState";
            this.groupBox_portState.Size = new System.Drawing.Size(128, 112);
            this.groupBox_portState.TabIndex = 2;
            this.groupBox_portState.TabStop = false;
            this.groupBox_portState.Text = "State";
            // 
            // label_portState
            // 
            this.label_portState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_portState.Location = new System.Drawing.Point(3, 16);
            this.label_portState.Name = "label_portState";
            this.label_portState.Size = new System.Drawing.Size(122, 93);
            this.label_portState.TabIndex = 0;
            this.label_portState.Text = "State";
            // 
            // serialPortLog
            // 
            this.serialPortLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serialPortLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.serialPortLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serialPortLog.Location = new System.Drawing.Point(3, 16);
            this.serialPortLog.Name = "serialPortLog";
            this.serialPortLog.ReadOnly = true;
            this.serialPortLog.Size = new System.Drawing.Size(128, 284);
            this.serialPortLog.TabIndex = 1;
            this.serialPortLog.Text = "";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_edit,
            this.menu_mode,
            this.menu_communication,
            this.menu_help});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(434, 24);
            this.menuStripMain.TabIndex = 5;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_open,
            this.menu_file_SaveAs});
            this.menu_file.Enabled = false;
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(37, 20);
            this.menu_file.Text = "File";
            // 
            // menu_file_open
            // 
            this.menu_file_open.Name = "menu_file_open";
            this.menu_file_open.Size = new System.Drawing.Size(180, 22);
            this.menu_file_open.Text = "Open";
            this.menu_file_open.Click += new System.EventHandler(this.menu_file_open_Click);
            // 
            // menu_file_SaveAs
            // 
            this.menu_file_SaveAs.Name = "menu_file_SaveAs";
            this.menu_file_SaveAs.Size = new System.Drawing.Size(180, 22);
            this.menu_file_SaveAs.Text = "Save As";
            this.menu_file_SaveAs.Click += new System.EventHandler(this.menu_file_SaveAs_Click);
            // 
            // menu_edit
            // 
            this.menu_edit.Enabled = false;
            this.menu_edit.Name = "menu_edit";
            this.menu_edit.Size = new System.Drawing.Size(39, 20);
            this.menu_edit.Text = "Edit";
            // 
            // menu_mode
            // 
            this.menu_mode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_mode_positioning,
            this.menu_mode_scan,
            this.menu_mode_simplified,
            this.menu_mode_professional});
            this.menu_mode.Name = "menu_mode";
            this.menu_mode.Size = new System.Drawing.Size(50, 20);
            this.menu_mode.Text = "Mode";
            // 
            // menu_mode_positioning
            // 
            this.menu_mode_positioning.Name = "menu_mode_positioning";
            this.menu_mode_positioning.Size = new System.Drawing.Size(138, 22);
            this.menu_mode_positioning.Text = "Positioning";
            this.menu_mode_positioning.Click += new System.EventHandler(this.menu_mode_positioning_Click);
            // 
            // menu_mode_scan
            // 
            this.menu_mode_scan.Name = "menu_mode_scan";
            this.menu_mode_scan.Size = new System.Drawing.Size(138, 22);
            this.menu_mode_scan.Text = "Scan 2D";
            this.menu_mode_scan.Click += new System.EventHandler(this.menu_mode_scan_Click);
            // 
            // menu_mode_simplified
            // 
            this.menu_mode_simplified.Enabled = false;
            this.menu_mode_simplified.Name = "menu_mode_simplified";
            this.menu_mode_simplified.Size = new System.Drawing.Size(138, 22);
            this.menu_mode_simplified.Text = "Simplified";
            this.menu_mode_simplified.Click += new System.EventHandler(this.menu_mode_simplified_Click);
            // 
            // menu_mode_professional
            // 
            this.menu_mode_professional.Enabled = false;
            this.menu_mode_professional.Name = "menu_mode_professional";
            this.menu_mode_professional.Size = new System.Drawing.Size(138, 22);
            this.menu_mode_professional.Text = "Professional";
            this.menu_mode_professional.Click += new System.EventHandler(this.menu_mode_professional_Click);
            // 
            // menu_communication
            // 
            this.menu_communication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.simulationToolStripMenuItem,
            this.testToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menu_communication.Name = "menu_communication";
            this.menu_communication.Size = new System.Drawing.Size(72, 20);
            this.menu_communication.Text = "Serial Port";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.simulationToolStripMenuItem.Text = "Simulation";
            this.simulationToolStripMenuItem.Click += new System.EventHandler(this.simulationToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Enabled = false;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // menu_help
            // 
            this.menu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.menu_help.Name = "menu_help";
            this.menu_help.Size = new System.Drawing.Size(44, 20);
            this.menu_help.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Enabled = false;
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_status,
            this.toolStripProgressBar1});
            this.statusStripMain.Location = new System.Drawing.Point(0, 539);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(434, 22);
            this.statusStripMain.TabIndex = 6;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // label_status
            // 
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(39, 17);
            this.label_status.Text = "Status";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Value = 50;
            // 
            // groupBox_code
            // 
            this.groupBox_code.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_code.Controls.Add(this.groupBox1);
            this.groupBox_code.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_code.Location = new System.Drawing.Point(146, 24);
            this.groupBox_code.Name = "groupBox_code";
            this.groupBox_code.Size = new System.Drawing.Size(154, 415);
            this.groupBox_code.TabIndex = 7;
            this.groupBox_code.TabStop = false;
            this.groupBox_code.Text = "Control";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_record);
            this.groupBox1.Controls.Add(this.checkBox_recording);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_path);
            this.groupBox1.Controls.Add(this.button_browse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ud_samplingFreq);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 193);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sampling";
            // 
            // panel_record
            // 
            this.panel_record.BackColor = System.Drawing.Color.Red;
            this.panel_record.Location = new System.Drawing.Point(113, 161);
            this.panel_record.Name = "panel_record";
            this.panel_record.Size = new System.Drawing.Size(15, 15);
            this.panel_record.TabIndex = 10;
            this.panel_record.Visible = false;
            // 
            // checkBox_recording
            // 
            this.checkBox_recording.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_recording.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_recording.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_recording.Location = new System.Drawing.Point(6, 149);
            this.checkBox_recording.Name = "checkBox_recording";
            this.checkBox_recording.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkBox_recording.Size = new System.Drawing.Size(139, 38);
            this.checkBox_recording.TabIndex = 9;
            this.checkBox_recording.Text = "RECORD";
            this.checkBox_recording.UseVisualStyleBackColor = true;
            this.checkBox_recording.CheckedChanged += new System.EventHandler(this.checkBox_recording_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Frequency:";
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(6, 94);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(139, 20);
            this.textBox_path.TabIndex = 7;
            // 
            // button_browse
            // 
            this.button_browse.AutoSize = true;
            this.button_browse.Location = new System.Drawing.Point(93, 120);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(52, 23);
            this.button_browse.TabIndex = 6;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hz";
            // 
            // ud_samplingFreq
            // 
            this.ud_samplingFreq.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ud_samplingFreq.Location = new System.Drawing.Point(76, 18);
            this.ud_samplingFreq.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ud_samplingFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud_samplingFreq.Name = "ud_samplingFreq";
            this.ud_samplingFreq.Size = new System.Drawing.Size(49, 20);
            this.ud_samplingFreq.TabIndex = 0;
            this.ud_samplingFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ud_samplingFreq.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ud_samplingFreq.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox_mode
            // 
            this.groupBox_mode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_mode.Controls.Add(this.mode_Scan2D1);
            this.groupBox_mode.Controls.Add(this.mode_Positioning1);
            this.groupBox_mode.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_mode.Location = new System.Drawing.Point(0, 24);
            this.groupBox_mode.Name = "groupBox_mode";
            this.groupBox_mode.Size = new System.Drawing.Size(146, 415);
            this.groupBox_mode.TabIndex = 8;
            this.groupBox_mode.TabStop = false;
            this.groupBox_mode.Text = "Mode Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveOutputFileDialog
            // 
            this.saveOutputFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveOutputFileDialog_FileOk);
            // 
            // mode_Scan2D1
            // 
            this.mode_Scan2D1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mode_Scan2D1.Location = new System.Drawing.Point(3, 16);
            this.mode_Scan2D1.Name = "mode_Scan2D1";
            this.mode_Scan2D1.Size = new System.Drawing.Size(140, 396);
            this.mode_Scan2D1.TabIndex = 1;
            // 
            // mode_Positioning1
            // 
            this.mode_Positioning1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mode_Positioning1.Location = new System.Drawing.Point(3, 16);
            this.mode_Positioning1.Name = "mode_Positioning1";
            this.mode_Positioning1.Size = new System.Drawing.Size(140, 396);
            this.mode_Positioning1.TabIndex = 0;
            // 
            // appLog1
            // 
            this.appLog1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.appLog1.Location = new System.Drawing.Point(0, 439);
            this.appLog1.Name = "appLog1";
            this.appLog1.Size = new System.Drawing.Size(434, 100);
            this.appLog1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.groupBox_log);
            this.Controls.Add(this.groupBox_code);
            this.Controls.Add(this.groupBox_mode);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.appLog1);
            this.Controls.Add(this.statusStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.MinimumSize = new System.Drawing.Size(450, 420);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VMD-10X Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox_log.ResumeLayout(false);
            this.groupBox_portState.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.groupBox_code.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_samplingFreq)).EndInit();
            this.groupBox_mode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_log;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.ToolStripMenuItem menu_edit;
        private System.Windows.Forms.ToolStripMenuItem menu_help;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.GroupBox groupBox_code;
        private System.Windows.Forms.ToolStripMenuItem menu_communication;
        private System.Windows.Forms.ToolStripMenuItem menu_file_open;
        private System.Windows.Forms.ToolStripMenuItem menu_file_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_mode;
        private System.Windows.Forms.ToolStripMenuItem menu_mode_positioning;
        private System.Windows.Forms.ToolStripMenuItem menu_mode_scan;
        private System.Windows.Forms.ToolStripMenuItem menu_mode_simplified;
        private System.Windows.Forms.ToolStripMenuItem menu_mode_professional;
        public System.Windows.Forms.GroupBox groupBox_mode;
        public System.Windows.Forms.ToolStripStatusLabel label_status;
        private System.Windows.Forms.GroupBox groupBox_portState;
        public System.Windows.Forms.Label label_portState;
        public System.Windows.Forms.RichTextBox serialPortLog;
        public System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Label label2;
        private Modes.Mode_Scan2D mode_Scan2D1;
        private Modes.Mode_Positioning mode_Positioning1;
        public AppLog appLog1;
        public System.Windows.Forms.NumericUpDown ud_samplingFreq;
        public System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.CheckBox checkBox_recording;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveOutputFileDialog;
        private System.Windows.Forms.Panel panel_record;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
    }
}

