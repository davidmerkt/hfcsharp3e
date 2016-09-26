using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwappingElephants
{
    public partial class MainForm : Form
    {
        Elephant lloyd;
        Elephant lucinda;

        public MainForm()
        {
            InitializeComponent();
            lloyd = new Elephant() { StrName = "Lloyd", IntEarSize = 40 };
            lucinda = new Elephant() { StrName = "Lucinda", IntEarSize = 33 };
        }

        private void btnLloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void btnLucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            Elephant swapper;
            swapper = lucinda;
            lucinda = lloyd;
            lloyd = swapper;
            MessageBox.Show("Objects Swapped", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.IntEarSize = 4321;
            lloyd.WhoAmI();
        }

        private void btnElephantTalk_Click(object sender, EventArgs e)
        {
            lloyd.TellMe("Hi", lucinda);
        }
    }
}
