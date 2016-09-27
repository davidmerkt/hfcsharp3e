using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagnets
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnIslands_Click(object sender, EventArgs e)
        {
            string result = "";

            string[] islands = new string[4];
            islands[0] = "Bermuda";
            islands[1] = "Fiji";
            islands[2] = "Azores";
            islands[3] = "Cozumel";

            int[] index = new int[4];
            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;

            int y = 0;
            int refNum;
            while (y < 4)
            {
                refNum = index[y];
                result += "\nisland = ";
                result += islands[refNum];
                y++;
            }
            MessageBox.Show(result);
        }
    }
}
