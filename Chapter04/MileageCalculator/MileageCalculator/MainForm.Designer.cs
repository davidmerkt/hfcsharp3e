namespace MileageCalculator
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
            this.lblStarting = new System.Windows.Forms.Label();
            this.lblEnding = new System.Windows.Forms.Label();
            this.lblAmountOwedLabel = new System.Windows.Forms.Label();
            this.lblAmountOwed = new System.Windows.Forms.Label();
            this.numStarting = new System.Windows.Forms.NumericUpDown();
            this.numEnding = new System.Windows.Forms.NumericUpDown();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnDisplayMiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numStarting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnding)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStarting
            // 
            this.lblStarting.AutoSize = true;
            this.lblStarting.Location = new System.Drawing.Point(12, 14);
            this.lblStarting.Name = "lblStarting";
            this.lblStarting.Size = new System.Drawing.Size(83, 13);
            this.lblStarting.TabIndex = 0;
            this.lblStarting.Text = "Starting Mileage";
            // 
            // lblEnding
            // 
            this.lblEnding.AutoSize = true;
            this.lblEnding.Location = new System.Drawing.Point(15, 40);
            this.lblEnding.Name = "lblEnding";
            this.lblEnding.Size = new System.Drawing.Size(80, 13);
            this.lblEnding.TabIndex = 1;
            this.lblEnding.Text = "Ending Mileage";
            // 
            // lblAmountOwedLabel
            // 
            this.lblAmountOwedLabel.AutoSize = true;
            this.lblAmountOwedLabel.Location = new System.Drawing.Point(21, 66);
            this.lblAmountOwedLabel.Name = "lblAmountOwedLabel";
            this.lblAmountOwedLabel.Size = new System.Drawing.Size(74, 13);
            this.lblAmountOwedLabel.TabIndex = 2;
            this.lblAmountOwedLabel.Text = "Amount Owed";
            // 
            // lblAmountOwed
            // 
            this.lblAmountOwed.AutoSize = true;
            this.lblAmountOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOwed.Location = new System.Drawing.Point(101, 61);
            this.lblAmountOwed.Name = "lblAmountOwed";
            this.lblAmountOwed.Size = new System.Drawing.Size(86, 20);
            this.lblAmountOwed.TabIndex = 3;
            this.lblAmountOwed.Text = "$$$ owed";
            // 
            // numStarting
            // 
            this.numStarting.Location = new System.Drawing.Point(101, 12);
            this.numStarting.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numStarting.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStarting.Name = "numStarting";
            this.numStarting.Size = new System.Drawing.Size(120, 20);
            this.numStarting.TabIndex = 4;
            this.numStarting.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numEnding
            // 
            this.numEnding.Location = new System.Drawing.Point(101, 38);
            this.numEnding.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numEnding.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEnding.Name = "numEnding";
            this.numEnding.Size = new System.Drawing.Size(120, 20);
            this.numEnding.TabIndex = 5;
            this.numEnding.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalc.Location = new System.Drawing.Point(12, 86);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(80, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnDisplayMiles
            // 
            this.btnDisplayMiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayMiles.Location = new System.Drawing.Point(192, 86);
            this.btnDisplayMiles.Name = "btnDisplayMiles";
            this.btnDisplayMiles.Size = new System.Drawing.Size(80, 23);
            this.btnDisplayMiles.TabIndex = 7;
            this.btnDisplayMiles.Text = "Display Miles";
            this.btnDisplayMiles.UseVisualStyleBackColor = true;
            this.btnDisplayMiles.Click += new System.EventHandler(this.btnDisplayMiles_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.btnDisplayMiles);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.numEnding);
            this.Controls.Add(this.numStarting);
            this.Controls.Add(this.lblAmountOwed);
            this.Controls.Add(this.lblAmountOwedLabel);
            this.Controls.Add(this.lblEnding);
            this.Controls.Add(this.lblStarting);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 160);
            this.Name = "MainForm";
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numStarting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStarting;
        private System.Windows.Forms.Label lblEnding;
        private System.Windows.Forms.Label lblAmountOwedLabel;
        private System.Windows.Forms.Label lblAmountOwed;
        private System.Windows.Forms.NumericUpDown numStarting;
        private System.Windows.Forms.NumericUpDown numEnding;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnDisplayMiles;
    }
}

