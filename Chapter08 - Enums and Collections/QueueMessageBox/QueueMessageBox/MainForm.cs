using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueMessageBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("first in line");
            myQueue.Enqueue("second in line");
            myQueue.Enqueue("third in line");
            myQueue.Enqueue("last in line");
            string takeALook = myQueue.Peek();
            string getFirst = myQueue.Dequeue();
            string getNext = myQueue.Dequeue();
            int howMany = myQueue.Count;
            myQueue.Clear();
            MessageBox.Show("Peek() returned: " + takeALook + "\n"
            + "The first Dequeue() returned: " + getFirst + "\n"
            + "The second Dequeue() returned: " + getNext + "\n"
            + "Count before Clear() was " + howMany + "\n"
            + "Count after Clear() is now " + myQueue.Count);
        }
    }
}
