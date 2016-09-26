using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class MainForm : Form
    {
        int startingMileage, endingMileage;
        double milesTraveled, amountOwed;
        const double reimburseRate = .39;

        private void btnDisplayMiles_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public MainForm()
        {
            InitializeComponent();

            lblAmountOwed.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numStarting.Value;
            endingMileage = (int)numEnding.Value;

            if (startingMileage < endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                lblAmountOwed.Text = "$" + amountOwed;
            }
            else
                MessageBox.Show("The starting mileage must be less than the ending mileage", "Cannot calculate mileage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
