namespace VMD_10X_Controller
{
    partial class SpeedPicker
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
            this.panel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(0, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(120, 5);
            this.panel.TabIndex = 35;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(26, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 13);
            this.label.TabIndex = 34;
            this.label.Text = "Speed";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar
            // 
            this.trackBar.LargeChange = 1000;
            this.trackBar.Location = new System.Drawing.Point(0, 0);
            this.trackBar.Maximum = 1570;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(120, 45);
            this.trackBar.SmallChange = 50;
            this.trackBar.TabIndex = 33;
            this.trackBar.TickFrequency = 100;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // SpeedPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.trackBar);
            this.Name = "SpeedPicker";
            this.Size = new System.Drawing.Size(120, 45);
            this.Load += new System.EventHandler(this.SpeedPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TrackBar trackBar;
    }
}
