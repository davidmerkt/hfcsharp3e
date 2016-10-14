using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner21
{
    public partial class MainForm : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public MainForm()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numNumberOfPeople.Value, chkHealthy.Checked, chkFancy.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numBirthday.Value, chkFancyBirthday.Checked, txtCakeWriting.Text);
            DisplayBirthdayPartyCost();
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

        private void numBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void chkFancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = chkFancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void txtCakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = txtCakeWriting.Text;
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            lblTooLong.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            lblBirthdayCostLabel.Text = cost.ToString("c");
        }
    }
}
