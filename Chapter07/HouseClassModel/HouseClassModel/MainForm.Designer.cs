﻿namespace HouseClassModel
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
            this.btnGoHere = new System.Windows.Forms.Button();
            this.btnGoThroughDoor = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGoHere
            // 
            this.btnGoHere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGoHere.Location = new System.Drawing.Point(12, 188);
            this.btnGoHere.Name = "btnGoHere";
            this.btnGoHere.Size = new System.Drawing.Size(75, 23);
            this.btnGoHere.TabIndex = 0;
            this.btnGoHere.Text = "Go here:";
            this.btnGoHere.UseVisualStyleBackColor = true;
            this.btnGoHere.Click += new System.EventHandler(this.btnGoHere_Click);
            // 
            // btnGoThroughDoor
            // 
            this.btnGoThroughDoor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoThroughDoor.Location = new System.Drawing.Point(12, 218);
            this.btnGoThroughDoor.Name = "btnGoThroughDoor";
            this.btnGoThroughDoor.Size = new System.Drawing.Size(258, 23);
            this.btnGoThroughDoor.TabIndex = 1;
            this.btnGoThroughDoor.Text = "Go through the door…";
            this.btnGoThroughDoor.UseVisualStyleBackColor = true;
            this.btnGoThroughDoor.Click += new System.EventHandler(this.btnGoThroughDoor_Click);
            // 
            // exits
            // 
            this.exits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(93, 188);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(177, 24);
            this.exits.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(12, 12);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(258, 170);
            this.txtDescription.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.btnGoThroughDoor);
            this.Controls.Add(this.btnGoHere);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainForm";
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoHere;
        private System.Windows.Forms.Button btnGoThroughDoor;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.TextBox txtDescription;
    }
}

