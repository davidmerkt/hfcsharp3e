namespace CowCalculator
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
            this.numNumberOfCows = new System.Windows.Forms.NumericUpDown();
            this.lblCows = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfCows)).BeginInit();
            this.SuspendLayout();
            // 
            // numNumberOfCows
            // 
            this.numNumberOfCows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumberOfCows.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNumberOfCows.Location = new System.Drawing.Point(90, 12);
            this.numNumberOfCows.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numNumberOfCows.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNumberOfCows.Name = "numNumberOfCows";
            this.numNumberOfCows.Size = new System.Drawing.Size(120, 22);
            this.numNumberOfCows.TabIndex = 0;
            this.numNumberOfCows.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numNumberOfCows.ValueChanged += new System.EventHandler(this.numNumberOfCows_ValueChanged);
            // 
            // lblCows
            // 
            this.lblCows.AutoSize = true;
            this.lblCows.Location = new System.Drawing.Point(12, 14);
            this.lblCows.Name = "lblCows";
            this.lblCows.Size = new System.Drawing.Size(41, 17);
            this.lblCows.TabIndex = 1;
            this.lblCows.Text = "Cows";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(90, 40);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 73);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCows);
            this.Controls.Add(this.numNumberOfCows);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(212, 115);
            this.Name = "MainForm";
            this.Text = "Cow Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfCows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numNumberOfCows;
        private System.Windows.Forms.Label lblCows;
        private System.Windows.Forms.Button btnCalculate;
        //private System.Windows.Forms.Button btnBagsOfFeed;
    }
}

