namespace PartyPlanner2
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
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCostLabel = new System.Windows.Forms.Label();
            this.numNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.chkFancy = new System.Windows.Forms.CheckBox();
            this.chkHealthy = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDinnerParty = new System.Windows.Forms.TabPage();
            this.tabBirthdayParty = new System.Windows.Forms.TabPage();
            this.txtCakeWriting = new System.Windows.Forms.TextBox();
            this.lblBirthdayCostLabel = new System.Windows.Forms.Label();
            this.lblBirthdayCost = new System.Windows.Forms.Label();
            this.lblTooLong = new System.Windows.Forms.Label();
            this.lblCakeWriting = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numBirthday = new System.Windows.Forms.NumericUpDown();
            this.chkFancyBirthday = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPeople)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDinnerParty.SuspendLayout();
            this.tabBirthdayParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfPeople
            // 
            this.lblNumberOfPeople.AutoSize = true;
            this.lblNumberOfPeople.Location = new System.Drawing.Point(3, 3);
            this.lblNumberOfPeople.Name = "lblNumberOfPeople";
            this.lblNumberOfPeople.Size = new System.Drawing.Size(122, 17);
            this.lblNumberOfPeople.TabIndex = 0;
            this.lblNumberOfPeople.Text = "Number of People";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(3, 103);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(40, 17);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "Cost";
            // 
            // lblCostLabel
            // 
            this.lblCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCostLabel.Location = new System.Drawing.Point(49, 102);
            this.lblCostLabel.Name = "lblCostLabel";
            this.lblCostLabel.Size = new System.Drawing.Size(100, 23);
            this.lblCostLabel.TabIndex = 2;
            // 
            // numNumberOfPeople
            // 
            this.numNumberOfPeople.Location = new System.Drawing.Point(6, 23);
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
            this.numNumberOfPeople.TabIndex = 3;
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
            this.chkFancy.Location = new System.Drawing.Point(6, 51);
            this.chkFancy.Name = "chkFancy";
            this.chkFancy.Size = new System.Drawing.Size(148, 21);
            this.chkFancy.TabIndex = 4;
            this.chkFancy.Text = "Fancy Decorations";
            this.chkFancy.UseVisualStyleBackColor = true;
            this.chkFancy.CheckedChanged += new System.EventHandler(this.chkFancy_CheckedChanged);
            // 
            // chkHealthy
            // 
            this.chkHealthy.AutoSize = true;
            this.chkHealthy.Location = new System.Drawing.Point(6, 78);
            this.chkHealthy.Name = "chkHealthy";
            this.chkHealthy.Size = new System.Drawing.Size(124, 21);
            this.chkHealthy.TabIndex = 5;
            this.chkHealthy.Text = "Healthy Option";
            this.chkHealthy.UseVisualStyleBackColor = true;
            this.chkHealthy.CheckedChanged += new System.EventHandler(this.chkHealthy_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDinnerParty);
            this.tabControl1.Controls.Add(this.tabBirthdayParty);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(282, 253);
            this.tabControl1.TabIndex = 6;
            // 
            // tabDinnerParty
            // 
            this.tabDinnerParty.Controls.Add(this.lblNumberOfPeople);
            this.tabDinnerParty.Controls.Add(this.lblCostLabel);
            this.tabDinnerParty.Controls.Add(this.chkHealthy);
            this.tabDinnerParty.Controls.Add(this.lblCost);
            this.tabDinnerParty.Controls.Add(this.numNumberOfPeople);
            this.tabDinnerParty.Controls.Add(this.chkFancy);
            this.tabDinnerParty.Location = new System.Drawing.Point(4, 25);
            this.tabDinnerParty.Name = "tabDinnerParty";
            this.tabDinnerParty.Padding = new System.Windows.Forms.Padding(3);
            this.tabDinnerParty.Size = new System.Drawing.Size(274, 224);
            this.tabDinnerParty.TabIndex = 0;
            this.tabDinnerParty.Text = "Dinner Party";
            this.tabDinnerParty.UseVisualStyleBackColor = true;
            // 
            // tabBirthdayParty
            // 
            this.tabBirthdayParty.Controls.Add(this.txtCakeWriting);
            this.tabBirthdayParty.Controls.Add(this.lblBirthdayCostLabel);
            this.tabBirthdayParty.Controls.Add(this.lblBirthdayCost);
            this.tabBirthdayParty.Controls.Add(this.lblTooLong);
            this.tabBirthdayParty.Controls.Add(this.lblCakeWriting);
            this.tabBirthdayParty.Controls.Add(this.label1);
            this.tabBirthdayParty.Controls.Add(this.numBirthday);
            this.tabBirthdayParty.Controls.Add(this.chkFancyBirthday);
            this.tabBirthdayParty.Location = new System.Drawing.Point(4, 25);
            this.tabBirthdayParty.Name = "tabBirthdayParty";
            this.tabBirthdayParty.Padding = new System.Windows.Forms.Padding(3);
            this.tabBirthdayParty.Size = new System.Drawing.Size(274, 224);
            this.tabBirthdayParty.TabIndex = 1;
            this.tabBirthdayParty.Text = "Birthday Party";
            this.tabBirthdayParty.UseVisualStyleBackColor = true;
            // 
            // txtCakeWriting
            // 
            this.txtCakeWriting.Location = new System.Drawing.Point(6, 95);
            this.txtCakeWriting.Name = "txtCakeWriting";
            this.txtCakeWriting.Size = new System.Drawing.Size(180, 22);
            this.txtCakeWriting.TabIndex = 12;
            this.txtCakeWriting.Text = "Happy Birthday‼";
            this.txtCakeWriting.TextChanged += new System.EventHandler(this.txtCakeWriting_TextChanged);
            // 
            // lblBirthdayCostLabel
            // 
            this.lblBirthdayCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBirthdayCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdayCostLabel.Location = new System.Drawing.Point(49, 120);
            this.lblBirthdayCostLabel.Name = "lblBirthdayCostLabel";
            this.lblBirthdayCostLabel.Size = new System.Drawing.Size(137, 23);
            this.lblBirthdayCostLabel.TabIndex = 11;
            // 
            // lblBirthdayCost
            // 
            this.lblBirthdayCost.AutoSize = true;
            this.lblBirthdayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdayCost.Location = new System.Drawing.Point(3, 121);
            this.lblBirthdayCost.Name = "lblBirthdayCost";
            this.lblBirthdayCost.Size = new System.Drawing.Size(40, 17);
            this.lblBirthdayCost.TabIndex = 10;
            this.lblBirthdayCost.Text = "Cost";
            // 
            // lblTooLong
            // 
            this.lblTooLong.AutoSize = true;
            this.lblTooLong.BackColor = System.Drawing.Color.Red;
            this.lblTooLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTooLong.Location = new System.Drawing.Point(97, 75);
            this.lblTooLong.Name = "lblTooLong";
            this.lblTooLong.Size = new System.Drawing.Size(91, 17);
            this.lblTooLong.TabIndex = 9;
            this.lblTooLong.Text = "TOO LONG";
            // 
            // lblCakeWriting
            // 
            this.lblCakeWriting.AutoSize = true;
            this.lblCakeWriting.Location = new System.Drawing.Point(3, 75);
            this.lblCakeWriting.Name = "lblCakeWriting";
            this.lblCakeWriting.Size = new System.Drawing.Size(88, 17);
            this.lblCakeWriting.TabIndex = 8;
            this.lblCakeWriting.Text = "Cake Writing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of People";
            // 
            // numBirthday
            // 
            this.numBirthday.Location = new System.Drawing.Point(6, 23);
            this.numBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBirthday.Name = "numBirthday";
            this.numBirthday.Size = new System.Drawing.Size(120, 22);
            this.numBirthday.TabIndex = 6;
            this.numBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBirthday.ValueChanged += new System.EventHandler(this.numBirthday_ValueChanged);
            // 
            // chkFancyBirthday
            // 
            this.chkFancyBirthday.AutoSize = true;
            this.chkFancyBirthday.Checked = true;
            this.chkFancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFancyBirthday.Location = new System.Drawing.Point(6, 51);
            this.chkFancyBirthday.Name = "chkFancyBirthday";
            this.chkFancyBirthday.Size = new System.Drawing.Size(148, 21);
            this.chkFancyBirthday.TabIndex = 7;
            this.chkFancyBirthday.Text = "Fancy Decorations";
            this.chkFancyBirthday.UseVisualStyleBackColor = true;
            this.chkFancyBirthday.CheckedChanged += new System.EventHandler(this.chkFancyBirthday_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(220, 225);
            this.Name = "MainForm";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPeople)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDinnerParty.ResumeLayout(false);
            this.tabDinnerParty.PerformLayout();
            this.tabBirthdayParty.ResumeLayout(false);
            this.tabBirthdayParty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfPeople;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCostLabel;
        private System.Windows.Forms.NumericUpDown numNumberOfPeople;
        private System.Windows.Forms.CheckBox chkFancy;
        private System.Windows.Forms.CheckBox chkHealthy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDinnerParty;
        private System.Windows.Forms.TabPage tabBirthdayParty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numBirthday;
        private System.Windows.Forms.CheckBox chkFancyBirthday;
        private System.Windows.Forms.TextBox txtCakeWriting;
        private System.Windows.Forms.Label lblBirthdayCostLabel;
        private System.Windows.Forms.Label lblBirthdayCost;
        private System.Windows.Forms.Label lblTooLong;
        private System.Windows.Forms.Label lblCakeWriting;
    }
}

