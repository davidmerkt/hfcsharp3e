namespace CodeMagnets
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
            this.btnIslands = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIslands
            // 
            this.btnIslands.Location = new System.Drawing.Point(12, 12);
            this.btnIslands.Name = "btnIslands";
            this.btnIslands.Size = new System.Drawing.Size(100, 23);
            this.btnIslands.TabIndex = 0;
            this.btnIslands.Text = "Show Islands";
            this.btnIslands.UseVisualStyleBackColor = true;
            this.btnIslands.Click += new System.EventHandler(this.btnIslands_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnIslands;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnIslands);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Islands";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIslands;
    }
}

