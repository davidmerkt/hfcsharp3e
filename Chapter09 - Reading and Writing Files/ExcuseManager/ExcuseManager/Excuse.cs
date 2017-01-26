using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExcuseManager
{
    class Excuse
    {
        public string Description;
        public string Results;
        public DateTime LastUsed;
        public string ExcusePath;

        public Excuse()
        {
            ExcusePath = "";
        }

        public Excuse(string excusePath)
        {
            OpenFile(excusePath);
        }

        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.excuse");
            if (fileNames.Length > 0)
            {
                OpenFile(fileNames[random.Next(fileNames.Length)]);
            }
            else
            {
                Description = "";
                Results = "";
                LastUsed = DateTime.Now;
                ExcusePath = "";
            }
        }

        public void OpenFile(string fileName)
        {
            ExcusePath = fileName;

            using (StreamReader reader = new StreamReader(ExcusePath))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }

        public void Save(string fileName)
        {
            //ExcusePath = fileName;
            using (StreamWriter writer = new StreamWriter(fileName))
            { 
                writer.WriteLine(Description);
                writer.WriteLine(Results);
                writer.WriteLine(LastUsed.ToString());
            }
        }
    }
}
