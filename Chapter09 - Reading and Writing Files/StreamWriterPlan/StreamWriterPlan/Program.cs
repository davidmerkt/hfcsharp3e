using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StreamWriterPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\secret_plan.txt";
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("How I’ll defeat Captain Amazing");
            sw.WriteLine("Another genius secret plan by The Swindler");
            sw.Write("I’ll create an army of clones and ");
            sw.WriteLine("unleash them upon the citizens of Objectville.");
            string location = "the mall";
            for (int number = 0; number <= 6; number++)
            {
                sw.WriteLine("Clone #{0} attacks {1}", number, location);
                if (location == "the mall") { location = "downtown"; }
                else { location = "the mall"; }
            }
            sw.Close();
        }
    }
}
