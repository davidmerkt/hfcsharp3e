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
        Excuse myExcuse = new Excuse();
        string excuseFolder;
        bool isChanged;
        Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
            myExcuse.LastUsed = lastUsedDate.Value;
            
            //
            folderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                excuseFolder = folderBrowserDialog1.SelectedPath;
                openFileDialog1.InitialDirectory = excuseFolder;
                saveFileDialog1.InitialDirectory = excuseFolder;
                enableButtons();
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = excuseTextBox.Text + ".excuse";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myExcuse.OpenFile(openFileDialog1.FileName);
                //excuseTextBox.Text = myExcuse.Description;
                //resultsTextBox.Text = myExcuse.Results;
                //lastUsedDate.Value = myExcuse.LastUsed;
                //fileDate.Text = File.GetCreationTime(openFileDialog1.FileName).ToString();
                UpdateMainForm(false);
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            myExcuse = new Excuse(random, excuseFolder);
            UpdateMainForm(false);
        }

        private void enableButtons()
        {
            openButton.Enabled = true;
            saveButton.Enabled = true;
            randomButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (excuseTextBox.Text != "")
            {
                if (resultsTextBox.Text != "")
                {
                    saveFileDialog1.FileName = excuseTextBox.Text + ".excuse";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        myExcuse.Save(saveFileDialog1.FileName);
                        UpdateMainForm(false);
                        MessageBox.Show("Excuse written");
                    }

                }
                else
                {
                    MessageBox.Show("Please specify a result", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please specify an excuse", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void excuseTextBox_TextChanged(object sender, EventArgs e)
        {
            myExcuse.Description = excuseTextBox.Text;
            isChanged = true;
            UpdateMainForm(isChanged);
        }

        private void resultsTextBox_TextChanged(object sender, EventArgs e)
        {
            myExcuse.Results = resultsTextBox.Text;
            isChanged = true;
            UpdateMainForm(isChanged);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            myExcuse.LastUsed = lastUsedDate.Value;
            isChanged = true;
            UpdateMainForm(isChanged);
        }

        private void UpdateMainForm(bool changed)
        {
            if (!changed)
            {
                this.excuseTextBox.Text = myExcuse.Description;
                this.resultsTextBox.Text = myExcuse.Results;
                this.lastUsedDate.Value = myExcuse.LastUsed;
                if (!String.IsNullOrEmpty(myExcuse.ExcusePath))
                    fileDate.Text = File.GetLastWriteTime(myExcuse.ExcusePath).ToString();
                this.Text = "Excuse Manager";
            }
            else
                this.Text = "Excuse Manager*";
            this.isChanged = changed;
        }
    }
}
