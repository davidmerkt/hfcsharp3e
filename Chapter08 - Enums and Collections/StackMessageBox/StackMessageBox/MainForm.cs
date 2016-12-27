using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackMessageBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("first in line");
            myStack.Push("second in line");
            myStack.Push("third in line");
            myStack.Push("last in line");
            string takeALook = myStack.Peek();
            string getFirst = myStack.Pop();
            string getNext = myStack.Pop();
            int howMany = myStack.Count;
            myStack.Clear();
            MessageBox.Show("Peek() returned: " + takeALook + "\n"
            + "The first Pop() returned: " + getFirst + "\n"
            + "The second Pop() returned: " + getNext + "\n"
            + "Count before Clear() was " + howMany + "\n"
            + "Count after Clear() is now " + myStack.Count);
        }
    }
}
