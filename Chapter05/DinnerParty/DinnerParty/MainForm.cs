using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public partial class MainForm : Form
    {
        DinnerParty dinnerParty;

        public MainForm()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerParty.SetHealthyOption(chkHealthy.Checked);
            dinnerParty.CalculateCostOfDecorations(chkFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            dinnerParty.NumberOfPeople = (int)numNumberOfPeople.Value;
            dinnerParty.CalculateCostOfDecorations(chkFancy.Checked);
            dinnerParty.SetHealthyOption(chkHealthy.Checked);

            decimal Cost = dinnerParty.CalculateCost(chkHealthy.Checked);
            lblCostLabel.Text = Cost.ToString("c");
        }

        private void numNumberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void chkFancy_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void chkHealthy_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }
    }
}
