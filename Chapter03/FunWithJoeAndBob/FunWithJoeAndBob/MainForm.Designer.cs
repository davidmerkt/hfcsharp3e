namespace FunWithJoeAndBob
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
            this.lblJoesCashLabel = new System.Windows.Forms.Label();
            this.lblBobsCashLabel = new System.Windows.Forms.Label();
            this.lblBankCashLabel = new System.Windows.Forms.Label();
            this.btnGIveCashToJoe = new System.Windows.Forms.Button();
            this.btnReceiveCashFromBob = new System.Windows.Forms.Button();
            this.btnJoeGiveToBob = new System.Windows.Forms.Button();
            this.btnBobGiveToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJoesCashLabel
            // 
            this.lblJoesCashLabel.AutoSize = true;
            this.lblJoesCashLabel.Location = new System.Drawing.Point(12, 9);
            this.lblJoesCashLabel.Name = "lblJoesCashLabel";
            this.lblJoesCashLabel.Size = new System.Drawing.Size(47, 13);
            this.lblJoesCashLabel.TabIndex = 0;
            this.lblJoesCashLabel.Text = "Joe has ";
            // 
            // lblBobsCashLabel
            // 
            this.lblBobsCashLabel.AutoSize = true;
            this.lblBobsCashLabel.Location = new System.Drawing.Point(12, 35);
            this.lblBobsCashLabel.Name = "lblBobsCashLabel";
            this.lblBobsCashLabel.Size = new System.Drawing.Size(49, 13);
            this.lblBobsCashLabel.TabIndex = 1;
            this.lblBobsCashLabel.Text = "Bob has ";
            // 
            // lblBankCashLabel
            // 
            this.lblBankCashLabel.AutoSize = true;
            this.lblBankCashLabel.Location = new System.Drawing.Point(12, 61);
            this.lblBankCashLabel.Name = "lblBankCashLabel";
            this.lblBankCashLabel.Size = new System.Drawing.Size(76, 13);
            this.lblBankCashLabel.TabIndex = 2;
            this.lblBankCashLabel.Text = "The bank has ";
            // 
            // btnGIveCashToJoe
            // 
            this.btnGIveCashToJoe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGIveCashToJoe.Location = new System.Drawing.Point(12, 151);
            this.btnGIveCashToJoe.Name = "btnGIveCashToJoe";
            this.btnGIveCashToJoe.Size = new System.Drawing.Size(85, 46);
            this.btnGIveCashToJoe.TabIndex = 0;
            this.btnGIveCashToJoe.Text = "Give $10 to Joe";
            this.btnGIveCashToJoe.UseVisualStyleBackColor = true;
            this.btnGIveCashToJoe.Click += new System.EventHandler(this.btnGIveCashToJoe_Click);
            // 
            // btnReceiveCashFromBob
            // 
            this.btnReceiveCashFromBob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceiveCashFromBob.Location = new System.Drawing.Point(187, 151);
            this.btnReceiveCashFromBob.Name = "btnReceiveCashFromBob";
            this.btnReceiveCashFromBob.Size = new System.Drawing.Size(85, 46);
            this.btnReceiveCashFromBob.TabIndex = 1;
            this.btnReceiveCashFromBob.Text = "Receive $5 from Bob";
            this.btnReceiveCashFromBob.UseVisualStyleBackColor = true;
            this.btnReceiveCashFromBob.Click += new System.EventHandler(this.btnReceiveCashFromBob_Click);
            // 
            // btnJoeGiveToBob
            // 
            this.btnJoeGiveToBob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnJoeGiveToBob.Location = new System.Drawing.Point(12, 203);
            this.btnJoeGiveToBob.Name = "btnJoeGiveToBob";
            this.btnJoeGiveToBob.Size = new System.Drawing.Size(85, 46);
            this.btnJoeGiveToBob.TabIndex = 2;
            this.btnJoeGiveToBob.Text = "Joe gives $10 to Bob";
            this.btnJoeGiveToBob.UseVisualStyleBackColor = true;
            this.btnJoeGiveToBob.Click += new System.EventHandler(this.btnJoeGiveToBob_Click);
            // 
            // btnBobGiveToJoe
            // 
            this.btnBobGiveToJoe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBobGiveToJoe.Location = new System.Drawing.Point(187, 203);
            this.btnBobGiveToJoe.Name = "btnBobGiveToJoe";
            this.btnBobGiveToJoe.Size = new System.Drawing.Size(85, 46);
            this.btnBobGiveToJoe.TabIndex = 3;
            this.btnBobGiveToJoe.Text = "Bob gives $5 to Joe";
            this.btnBobGiveToJoe.UseVisualStyleBackColor = true;
            this.btnBobGiveToJoe.Click += new System.EventHandler(this.btnBobGiveToJoe_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnBobGiveToJoe);
            this.Controls.Add(this.btnJoeGiveToBob);
            this.Controls.Add(this.btnReceiveCashFromBob);
            this.Controls.Add(this.btnGIveCashToJoe);
            this.Controls.Add(this.lblBankCashLabel);
            this.Controls.Add(this.lblBobsCashLabel);
            this.Controls.Add(this.lblJoesCashLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(225, 225);
            this.Name = "MainForm";
            this.Text = "Fun With Joe And Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJoesCashLabel;
        private System.Windows.Forms.Label lblBobsCashLabel;
        private System.Windows.Forms.Label lblBankCashLabel;
        private System.Windows.Forms.Button btnGIveCashToJoe;
        private System.Windows.Forms.Button btnReceiveCashFromBob;
        private System.Windows.Forms.Button btnJoeGiveToBob;
        private System.Windows.Forms.Button btnBobGiveToJoe;
    }
}

