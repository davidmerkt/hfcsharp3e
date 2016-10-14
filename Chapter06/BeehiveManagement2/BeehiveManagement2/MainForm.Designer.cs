namespace BeehiveManagement2
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
            this.grpWorkerBeeAssignments = new System.Windows.Forms.GroupBox();
            this.btnWork = new System.Windows.Forms.Button();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.btnAssignJob = new System.Windows.Forms.Button();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblShifts = new System.Windows.Forms.Label();
            this.cmbWorkerBeeJob = new System.Windows.Forms.ComboBox();
            this.numShifts = new System.Windows.Forms.NumericUpDown();
            this.grpWorkerBeeAssignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // grpWorkerBeeAssignments
            // 
            this.grpWorkerBeeAssignments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWorkerBeeAssignments.Controls.Add(this.numShifts);
            this.grpWorkerBeeAssignments.Controls.Add(this.cmbWorkerBeeJob);
            this.grpWorkerBeeAssignments.Controls.Add(this.lblShifts);
            this.grpWorkerBeeAssignments.Controls.Add(this.lblJob);
            this.grpWorkerBeeAssignments.Controls.Add(this.btnAssignJob);
            this.grpWorkerBeeAssignments.Location = new System.Drawing.Point(12, 12);
            this.grpWorkerBeeAssignments.Name = "grpWorkerBeeAssignments";
            this.grpWorkerBeeAssignments.Size = new System.Drawing.Size(492, 100);
            this.grpWorkerBeeAssignments.TabIndex = 0;
            this.grpWorkerBeeAssignments.TabStop = false;
            this.grpWorkerBeeAssignments.Text = "Worker Bee Assignments";
            // 
            // btnWork
            // 
            this.btnWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWork.Location = new System.Drawing.Point(510, 12);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(100, 100);
            this.btnWork.TabIndex = 1;
            this.btnWork.Text = "Work the next shift";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // txtReport
            // 
            this.txtReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReport.Location = new System.Drawing.Point(12, 118);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(598, 303);
            this.txtReport.TabIndex = 2;
            // 
            // btnAssignJob
            // 
            this.btnAssignJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignJob.Location = new System.Drawing.Point(9, 68);
            this.btnAssignJob.Name = "btnAssignJob";
            this.btnAssignJob.Size = new System.Drawing.Size(477, 23);
            this.btnAssignJob.TabIndex = 0;
            this.btnAssignJob.Text = "Assign this job to a bee";
            this.btnAssignJob.UseVisualStyleBackColor = true;
            this.btnAssignJob.Click += new System.EventHandler(this.btnAssignJob_Click);
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(6, 18);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(31, 17);
            this.lblJob.TabIndex = 1;
            this.lblJob.Text = "Job";
            // 
            // lblShifts
            // 
            this.lblShifts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShifts.AutoSize = true;
            this.lblShifts.Location = new System.Drawing.Point(383, 18);
            this.lblShifts.Name = "lblShifts";
            this.lblShifts.Size = new System.Drawing.Size(43, 17);
            this.lblShifts.TabIndex = 2;
            this.lblShifts.Text = "Shifts";
            // 
            // cmbWorkerBeeJob
            // 
            this.cmbWorkerBeeJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWorkerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkerBeeJob.FormattingEnabled = true;
            this.cmbWorkerBeeJob.Items.AddRange(new object[] {
            "Baby bee tutoring",
            "Egg care",
            "Hive maintenance",
            "Honey manufacturing",
            "Nectar collector",
            "Sting patrol"});
            this.cmbWorkerBeeJob.Location = new System.Drawing.Point(9, 38);
            this.cmbWorkerBeeJob.Name = "cmbWorkerBeeJob";
            this.cmbWorkerBeeJob.Size = new System.Drawing.Size(371, 24);
            this.cmbWorkerBeeJob.TabIndex = 3;
            // 
            // numShifts
            // 
            this.numShifts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numShifts.Location = new System.Drawing.Point(386, 39);
            this.numShifts.Name = "numShifts";
            this.numShifts.Size = new System.Drawing.Size(100, 22);
            this.numShifts.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnWork;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.grpWorkerBeeAssignments);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.Text = "Beehive Management System";
            this.grpWorkerBeeAssignments.ResumeLayout(false);
            this.grpWorkerBeeAssignments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWorkerBeeAssignments;
        private System.Windows.Forms.NumericUpDown numShifts;
        private System.Windows.Forms.ComboBox cmbWorkerBeeJob;
        private System.Windows.Forms.Label lblShifts;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Button btnAssignJob;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.TextBox txtReport;
    }
}