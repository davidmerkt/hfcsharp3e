using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class MainForm : Form
    {
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Random MyRandomizer = new Random();

        public MainForm()
        {
            InitializeComponent();
            
            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                Randomizer = MyRandomizer
            };
        }

        private void btnStartRace_Click(object sender, EventArgs e)
        {
            grpBettingParlor.Enabled = false;
        }
    }
}
