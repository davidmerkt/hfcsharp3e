using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_2___Program_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeText_Click(object sender, EventArgs e)
        {
            if (chkEnableCheckbox.Checked == true)
            {
                if (lblLabelToChange.Text == "Right")
                {
                    lblLabelToChange.Text = "Left";
                    lblLabelToChange.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    lblLabelToChange.Text = "Right";
                    lblLabelToChange.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                lblLabelToChange.Text = "Text changing is disabled";
                lblLabelToChange.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
