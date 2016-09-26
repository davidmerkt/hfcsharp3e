namespace SwappingElephants
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
            this.btnLloyd = new System.Windows.Forms.Button();
            this.btnLucinda = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnElephantTalk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLloyd
            // 
            this.btnLloyd.Location = new System.Drawing.Point(12, 12);
            this.btnLloyd.Name = "btnLloyd";
            this.btnLloyd.Size = new System.Drawing.Size(75, 23);
            this.btnLloyd.TabIndex = 0;
            this.btnLloyd.Text = "Lloyd";
            this.btnLloyd.UseVisualStyleBackColor = true;
            this.btnLloyd.Click += new System.EventHandler(this.btnLloyd_Click);
            // 
            // btnLucinda
            // 
            this.btnLucinda.Location = new System.Drawing.Point(12, 41);
            this.btnLucinda.Name = "btnLucinda";
            this.btnLucinda.Size = new System.Drawing.Size(75, 23);
            this.btnLucinda.TabIndex = 1;
            this.btnLucinda.Text = "Lucinda";
            this.btnLucinda.UseVisualStyleBackColor = true;
            this.btnLucinda.Click += new System.EventHandler(this.btnLucinda_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(12, 70);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 2;
            this.btnSwap.Text = "Swap‼";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnElephantTalk
            // 
            this.btnElephantTalk.Location = new System.Drawing.Point(12, 128);
            this.btnElephantTalk.Name = "btnElephantTalk";
            this.btnElephantTalk.Size = new System.Drawing.Size(85, 23);
            this.btnElephantTalk.TabIndex = 4;
            this.btnElephantTalk.Text = "Elephant Talk";
            this.btnElephantTalk.UseVisualStyleBackColor = true;
            this.btnElephantTalk.Click += new System.EventHandler(this.btnElephantTalk_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnElephantTalk);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnLucinda);
            this.Controls.Add(this.btnLloyd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Swap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLloyd;
        private System.Windows.Forms.Button btnLucinda;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnElephantTalk;
    }
}

