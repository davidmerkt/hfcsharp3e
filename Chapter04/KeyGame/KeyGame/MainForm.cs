using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGame
{
    public partial class MainForm : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public MainForm()
        {
            InitializeComponent();
        }

        private void tmrDifficulty_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over");
                tmrDifficulty.Stop();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (tmrDifficulty.Interval > 400)
                    tmrDifficulty.Interval -= 10;
                if (tmrDifficulty.Interval > 250)
                    tmrDifficulty.Interval -= 7;
                if (tmrDifficulty.Interval > 100)
                    tmrDifficulty.Interval -= 2;
                stsDifficultyProgressBar.Value = 800 - tmrDifficulty.Interval;

                stats.Update(true);
            }
            else
                stats.Update(false);

            stsCorrect.Text = "Correct: " + stats.Correct;
            stsMissed.Text = "Missed: " + stats.Missed;
            stsTotal.Text = "Total: " + stats.Total;
            stsAccuracy.Text = "Accuracy: " + stats.Accuracy + "%";
        }
    }
}
