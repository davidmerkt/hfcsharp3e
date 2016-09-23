namespace Chapter_2___Program_4
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
            this.btnChangeText = new System.Windows.Forms.Button();
            this.chkEnableCheckbox = new System.Windows.Forms.CheckBox();
            this.lblLabelToChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeText
            // 
            this.btnChangeText.Location = new System.Drawing.Point(12, 12);
            this.btnChangeText.Name = "btnChangeText";
            this.btnChangeText.Size = new System.Drawing.Size(200, 23);
            this.btnChangeText.TabIndex = 0;
            this.btnChangeText.Text = "Change the label if checked";
            this.btnChangeText.UseVisualStyleBackColor = true;
            this.btnChangeText.Click += new System.EventHandler(this.btnChangeText_Click);
            // 
            // chkEnableCheckbox
            // 
            this.chkEnableCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnableCheckbox.AutoSize = true;
            this.chkEnableCheckbox.Location = new System.Drawing.Point(300, 14);
            this.chkEnableCheckbox.Name = "chkEnableCheckbox";
            this.chkEnableCheckbox.Size = new System.Drawing.Size(170, 21);
            this.chkEnableCheckbox.TabIndex = 1;
            this.chkEnableCheckbox.Text = "Enable label changing";
            this.chkEnableCheckbox.UseVisualStyleBackColor = true;
            // 
            // lblLabelToChange
            // 
            this.lblLabelToChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabelToChange.Location = new System.Drawing.Point(12, 57);
            this.lblLabelToChange.Name = "lblLabelToChange";
            this.lblLabelToChange.Size = new System.Drawing.Size(458, 23);
            this.lblLabelToChange.TabIndex = 2;
            this.lblLabelToChange.Text = "Press the button to change my text";
            this.lblLabelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 83);
            this.Controls.Add(this.lblLabelToChange);
            this.Controls.Add(this.chkEnableCheckbox);
            this.Controls.Add(this.btnChangeText);
            this.Name = "Form1";
            this.Text = "My Desktop App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeText;
        private System.Windows.Forms.CheckBox chkEnableCheckbox;
        private System.Windows.Forms.Label lblLabelToChange;
    }
}

