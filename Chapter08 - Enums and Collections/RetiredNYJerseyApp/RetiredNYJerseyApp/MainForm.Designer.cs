namespace RetiredNYJerseyApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberCombo = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "was worn by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "and retired in";
            // 
            // numberCombo
            // 
            this.numberCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberCombo.FormattingEnabled = true;
            this.numberCombo.Location = new System.Drawing.Point(76, 12);
            this.numberCombo.Name = "numberCombo";
            this.numberCombo.Size = new System.Drawing.Size(100, 24);
            this.numberCombo.TabIndex = 3;
            this.numberCombo.SelectedIndexChanged += new System.EventHandler(this.numberCombo_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(273, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.ReadOnly = true;
            this.nameLabel.Size = new System.Drawing.Size(158, 22);
            this.nameLabel.TabIndex = 4;
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(535, 12);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.ReadOnly = true;
            this.yearLabel.Size = new System.Drawing.Size(75, 22);
            this.yearLabel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 53);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.numberCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 100);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Retired Jersey Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox numberCombo;
        private System.Windows.Forms.TextBox nameLabel;
        private System.Windows.Forms.TextBox yearLabel;
    }
}

