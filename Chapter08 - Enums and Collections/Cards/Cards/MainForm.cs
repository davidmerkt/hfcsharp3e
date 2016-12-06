using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class MainForm : Form
    {
        Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void returnCard_Click(object sender, EventArgs e)
        {
            
            int numberBetween0and3 = random.Next(4);
            int numberBeetween1and13 = random.Next(2, 15);

            Card card = new Card((Suits)numberBetween0and3, (Values)numberBeetween1and13);
            MessageBox.Show(card.Name);
        }
    }
}
