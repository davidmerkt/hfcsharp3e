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
            
        }
    }
}
