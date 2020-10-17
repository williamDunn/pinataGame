namespace test
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHighScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblReset = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslCurrent,
            this.toolStripStatusLabel2,
            this.tsslHighScore});
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(691, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(105, 20);
            this.toolStripStatusLabel1.Text = "Current Score: ";
            // 
            // tsslCurrent
            // 
            this.tsslCurrent.Name = "tsslCurrent";
            this.tsslCurrent.Size = new System.Drawing.Size(151, 20);
            this.tsslCurrent.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(85, 20);
            this.toolStripStatusLabel2.Text = "High Score:";
            // 
            // tsslHighScore
            // 
            this.tsslHighScore.Name = "tsslHighScore";
            this.tsslHighScore.Size = new System.Drawing.Size(151, 20);
            this.tsslHighScore.Text = "toolStripStatusLabel3";
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Location = new System.Drawing.Point(585, 571);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(94, 17);
            this.lblReset.TabIndex = 1;
            this.lblReset.Text = "Click to Reset";
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 588);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.statusStrip1);
            this.MaximumSize = new System.Drawing.Size(709, 635);
            this.MinimumSize = new System.Drawing.Size(709, 635);
            this.Name = "Form1";
            this.Text = "Pinata";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCurrent;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslHighScore;
        private System.Windows.Forms.Label lblReset;
    }
}

