using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ExcuseManager
{
    public partial class MainForm : Form
    {
        Excuse myExcuse;
        string excuseFolder;
        bool isChanged;

        public MainForm()
        {
            InitializeComponent();
            folderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            myExcuse = new Excuse();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                excuseFolder = folderBrowserDialog1.SelectedPath;
                openFileDialog1.InitialDirectory = excuseFolder;
                enableButtons();
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myExcuse.OpenFile(openFileDialog1.FileName);
                excuseTextBox.Text = myExcuse.Description;
                resultsTextBox.Text = myExcuse.Results;
                dateTimePicker1.Value = myExcuse.LastUsed;
                fileDate.Text = File.GetCreationTime(openFileDialog1.FileName).ToString();
            }
        }

        private void enableButtons()
        {
            openButton.Enabled = true;
            saveButton.Enabled = true;
            randomButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void excuseTextBox_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
            UpdateMainForm(isChanged);
        }

        private void resultsTextBox_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
            UpdateMainForm(isChanged);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            isChanged = true;
            UpdateMainForm(isChanged);
        }

        private void UpdateMainForm(bool changed)
        {
            if (!changed)
            {
                this.excuseTextBox.Text = myExcuse.Description;
                this.resultsTextBox.Text = myExcuse.Results;
                this.dateTimePicker1.Value = myExcuse.LastUsed;
                if (!string.IsNullOrEmpty(myExcuse.ExcusePath))
                {
                    fileDate.Text = File.GetLastWriteTime(myExcuse.ExcusePath).ToString(); this.Text = "Excuse Manager";
                }
                else
                {
                    this.Text = "Excuse Manager*";
                }
                //this.formChanged = changed;
            }
        }
    }
}
