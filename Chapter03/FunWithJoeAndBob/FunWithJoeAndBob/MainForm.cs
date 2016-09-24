using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithJoeAndBob
{
    public partial class MainForm : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public MainForm()
        {
            InitializeComponent();
            joe = new Guy() { Name = "Joe", Cash = 50 };
            bob = new Guy() { Name = "Bob", Cash = 100 };
            UpdateForm();
        }

        public void UpdateForm()
        {
            lblJoesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            lblBobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            lblBankCashLabel.Text = "The bank has $" + bank;
        }

        private void btnGIveCashToJoe_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money‼",
                    "Bank Run",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnReceiveCashFromBob_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void btnJoeGiveToBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void btnBobGiveToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }
    }
}
