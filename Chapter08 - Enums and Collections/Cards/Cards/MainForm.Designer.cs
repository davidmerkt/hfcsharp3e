namespace Cards
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
            this.drawCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawCard
            // 
            this.drawCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawCard.Location = new System.Drawing.Point(12, 12);
            this.drawCard.Name = "drawCard";
            this.drawCard.Size = new System.Drawing.Size(278, 169);
            this.drawCard.TabIndex = 0;
            this.drawCard.Text = "Draw a Card";
            this.drawCard.UseVisualStyleBackColor = true;
            this.drawCard.Click += new System.EventHandler(this.returnCard_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.drawCard;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 193);
            this.Controls.Add(this.drawCard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 100);
            this.Name = "MainForm";
            this.Text = "Cards";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawCard;
    }
}

