using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeehiveManagement2
{
    public partial class MainForm : Form
    {
        Queen queen;

        public MainForm()
        {
            InitializeComponent();
            cmbWorkerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Honey manufacturing" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);

            queen = new Queen(workers, 275);
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            txtReport.Text = queen.WorkTheNextShift();
        }

        private void btnAssignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(cmbWorkerBeeJob.Text, (int)numShifts.Value) == false)
                MessageBox.Show("No workers are available to do the job '" + cmbWorkerBeeJob.Text + "'", "The queen bee says…", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("The job '" + cmbWorkerBeeJob.Text + "' will be done in " + numShifts.Value + " shifts", "The queen bee says…", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
