namespace DinnerParty
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
            this.lblNumberOfPeople = new System.Windows.Forms.Label();
            this.numNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.chkFancy = new System.Windows.Forms.CheckBox();
            this.chkHealthy = new System.Windows.Forms.CheckBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfPeople
            // 
            this.lblNumberOfPeople.AutoSize = true;
            this.lblNumberOfPeople.Location = new System.Drawing.Point(12, 9);
            this.lblNumberOfPeople.Name = "lblNumberOfPeople";
            this.lblNumberOfPeople.Size = new System.Drawing.Size(122, 17);
            this.lblNumberOfPeople.TabIndex = 0;
            this.lblNumberOfPeople.Text = "Number of People";
            // 
            // numNumberOfPeople
            // 
            this.numNumberOfPeople.Location = new System.Drawing.Point(15, 29);
            this.numNumberOfPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numNumberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfPeople.Name = "numNumberOfPeople";
            this.numNumberOfPeople.Size = new System.Drawing.Size(120, 22);
            this.numNumberOfPeople.TabIndex = 1;
            this.numNumberOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNumberOfPeople.ValueChanged += new System.EventHandler(this.numNumberOfPeople_ValueChanged);
            // 
            // chkFancy
            // 
            this.chkFancy.AutoSize = true;
            this.chkFancy.Checked = true;
            this.chkFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFancy.Location = new System.Drawing.Point(15, 57);
            this.chkFancy.Name = "chkFancy";
            this.chkFancy.Size = new System.Drawing.Size(148, 21);
            this.chkFancy.TabIndex = 2;
            this.chkFancy.Text = "Fancy Decorations";
            this.chkFancy.UseVisualStyleBackColor = true;
            this.chkFancy.CheckedChanged += new System.EventHandler(this.chkFancy_CheckedChanged);
            // 
            // chkHealthy
            // 
            this.chkHealthy.AutoSize = true;
            this.chkHealthy.Location = new System.Drawing.Point(15, 84);
            this.chkHealthy.Name = "chkHealthy";
            this.chkHealthy.Size = new System.Drawing.Size(124, 21);
            this.chkHealthy.TabIndex = 3;
            this.chkHealthy.Text = "Healthy Option";
            this.chkHealthy.UseVisualStyleBackColor = true;
            this.chkHealthy.CheckedChanged += new System.EventHandler(this.chkHealthy_CheckedChanged);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(12, 108);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(40, 17);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost";
            // 
            // lblCostLabel
            // 
            this.lblCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCostLabel.Location = new System.Drawing.Point(58, 108);
            this.lblCostLabel.Name = "lblCostLabel";
            this.lblCostLabel.Size = new System.Drawing.Size(100, 23);
            this.lblCostLabel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lblCostLabel);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.chkHealthy);
            this.Controls.Add(this.chkFancy);
            this.Controls.Add(this.numNumberOfPeople);
            this.Controls.Add(this.lblNumberOfPeople);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfPeople;
        private System.Windows.Forms.NumericUpDown numNumberOfPeople;
        private System.Windows.Forms.CheckBox chkFancy;
        private System.Windows.Forms.CheckBox chkHealthy;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCostLabel;
    }
}

