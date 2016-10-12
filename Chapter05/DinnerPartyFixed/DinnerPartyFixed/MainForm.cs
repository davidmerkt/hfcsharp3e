using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerPartyFixed
{
    public partial class MainForm : Form
    {
        DinnerParty dinnerParty;

        public MainForm()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numNumberOfPeople.Value, chkHealthy.Checked, chkFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void numNumberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numNumberOfPeople.Value;
            DisplayDinnerPartyCost();
        }

        private void chkFancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = chkFancy.Checked;
            DisplayDinnerPartyCost();
        }

        private void chkHealthy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = chkHealthy.Checked;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.Cost;
            lblCostLabel.Text = cost.ToString("c");
        }
    }
}
