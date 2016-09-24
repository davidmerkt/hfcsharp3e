namespace TalkerTester
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
            this.lblSayThis = new System.Windows.Forms.Label();
            this.lblNumTries = new System.Windows.Forms.Label();
            this.txtTextToSay = new System.Windows.Forms.TextBox();
            this.numTimesToRepeat = new System.Windows.Forms.NumericUpDown();
            this.btnSpeak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesToRepeat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSayThis
            // 
            this.lblSayThis.AutoSize = true;
            this.lblSayThis.Location = new System.Drawing.Point(12, 15);
            this.lblSayThis.Name = "lblSayThis";
            this.lblSayThis.Size = new System.Drawing.Size(47, 13);
            this.lblSayThis.TabIndex = 0;
            this.lblSayThis.Text = "Say this:";
            // 
            // lblNumTries
            // 
            this.lblNumTries.AutoSize = true;
            this.lblNumTries.Location = new System.Drawing.Point(12, 40);
            this.lblNumTries.Name = "lblNumTries";
            this.lblNumTries.Size = new System.Drawing.Size(51, 13);
            this.lblNumTries.TabIndex = 1;
            this.lblNumTries.Text = "# of tries:";
            // 
            // txtTextToSay
            // 
            this.txtTextToSay.Location = new System.Drawing.Point(69, 12);
            this.txtTextToSay.Name = "txtTextToSay";
            this.txtTextToSay.Size = new System.Drawing.Size(203, 20);
            this.txtTextToSay.TabIndex = 2;
            this.txtTextToSay.Text = "Hello‼";
            // 
            // numTimesToRepeat
            // 
            this.numTimesToRepeat.Location = new System.Drawing.Point(69, 38);
            this.numTimesToRepeat.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTimesToRepeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimesToRepeat.Name = "numTimesToRepeat";
            this.numTimesToRepeat.Size = new System.Drawing.Size(100, 20);
            this.numTimesToRepeat.TabIndex = 3;
            this.numTimesToRepeat.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(69, 64);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(100, 23);
            this.btnSpeak.TabIndex = 4;
            this.btnSpeak.Text = "Speak to me";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSpeak;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.numTimesToRepeat);
            this.Controls.Add(this.txtTextToSay);
            this.Controls.Add(this.lblNumTries);
            this.Controls.Add(this.lblSayThis);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "Form1";
            this.Text = "Talker Tester";
            ((System.ComponentModel.ISupportInitialize)(this.numTimesToRepeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayThis;
        private System.Windows.Forms.Label lblNumTries;
        private System.Windows.Forms.TextBox txtTextToSay;
        private System.Windows.Forms.NumericUpDown numTimesToRepeat;
        private System.Windows.Forms.Button btnSpeak;
    }
}

