using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FilePad
{
    public partial class MainForm : Form
    {
        private string name;

        public MainForm()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name))
            {
                saveFileDialog1.Title = "Save - " + name;
                saveFileDialog1.FileName = name;
                saveFileDialog1.Filter = "|*" + findFileExtension();
            }
            else
                saveFileDialog1.Filter = "Text File (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
            }
        }

        private string findFileExtension()
        {
            int index = name.LastIndexOf(".");
            if (index > 0)
            {
                string extension = name.Remove(0, index);
                return extension;
            }
            else return "";
        }
    }
}
