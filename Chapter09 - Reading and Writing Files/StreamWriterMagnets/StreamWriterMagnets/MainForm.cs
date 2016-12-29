using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StreamWriterMagnets
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flobbo f = new Flobbo("blue yellow");
            StreamWriter sw = f.Snobbo();
            f.Blobbo(f.Blobbo(f.Blobbo(sw), sw), sw);
        }
    }

    class Flobbo
    {
        private string zap;

        public Flobbo(string zap)
        {
            this.zap = zap;
        }

        public bool Blobbo(bool Already, StreamWriter sw)
        {
            if (Already)
            {
                sw.WriteLine(zap);
                sw.Close();
                return false;
            }
            else
            {
                sw.WriteLine(zap);
                zap = "red orange";
                return true;
            }
        }

        public bool Blobbo(StreamWriter sw)
        {
            sw.WriteLine(zap);
            zap = "green purple";
            return false;
        }

        public StreamWriter Snobbo()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\macaw.txt";
            return new StreamWriter(path);
        }

    }
}
