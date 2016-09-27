namespace KeyGame
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tmrDifficulty = new System.Windows.Forms.Timer(this.components);
            this.stsCorrect = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsMissed = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsAccuracy = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsDifficulty = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsDifficultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 135;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1078, 153);
            this.listBox1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsCorrect,
            this.stsMissed,
            this.stsTotal,
            this.stsAccuracy,
            this.stsDifficulty,
            this.stsDifficultyProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 128);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1078, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tmrDifficulty
            // 
            this.tmrDifficulty.Enabled = true;
            this.tmrDifficulty.Interval = 800;
            this.tmrDifficulty.Tick += new System.EventHandler(this.tmrDifficulty_Tick);
            // 
            // stsCorrect
            // 
            this.stsCorrect.Name = "stsCorrect";
            this.stsCorrect.Size = new System.Drawing.Size(72, 20);
            this.stsCorrect.Text = "Correct: 0";
            // 
            // stsMissed
            // 
            this.stsMissed.Name = "stsMissed";
            this.stsMissed.Size = new System.Drawing.Size(70, 20);
            this.stsMissed.Text = "Missed: 0";
            // 
            // stsTotal
            // 
            this.stsTotal.Name = "stsTotal";
            this.stsTotal.Size = new System.Drawing.Size(58, 20);
            this.stsTotal.Text = "Total: 0";
            // 
            // stsAccuracy
            // 
            this.stsAccuracy.Name = "stsAccuracy";
            this.stsAccuracy.Size = new System.Drawing.Size(95, 20);
            this.stsAccuracy.Text = "Accuracy: 0%";
            // 
            // stsDifficulty
            // 
            this.stsDifficulty.Name = "stsDifficulty";
            this.stsDifficulty.Size = new System.Drawing.Size(470, 20);
            this.stsDifficulty.Spring = true;
            this.stsDifficulty.Text = "Difficulty";
            this.stsDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stsDifficultyProgressBar
            // 
            this.stsDifficultyProgressBar.Maximum = 701;
            this.stsDifficultyProgressBar.Name = "stsDifficultyProgressBar";
            this.stsDifficultyProgressBar.Size = new System.Drawing.Size(100, 19);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 153);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hit the keys‼";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsCorrect;
        private System.Windows.Forms.ToolStripStatusLabel stsMissed;
        private System.Windows.Forms.ToolStripStatusLabel stsTotal;
        private System.Windows.Forms.ToolStripStatusLabel stsAccuracy;
        private System.Windows.Forms.ToolStripStatusLabel stsDifficulty;
        private System.Windows.Forms.ToolStripProgressBar stsDifficultyProgressBar;
        private System.Windows.Forms.Timer tmrDifficulty;
    }
}

