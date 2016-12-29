using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StreamReadWritePlan
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine("The folder path is: {0}", folder);
            
            try
            {
                StreamReader reader = new StreamReader(folder + @"\secret_plan.txt");
                StreamWriter writer = new StreamWriter(folder + @"\emailToCaptainAmazing.txt");
                Console.WriteLine("Begin email composition…");
                writer.WriteLine("To: CaptainAmazing@objectville.net");
                writer.WriteLine("From: Commissioner@objectville.net");
                writer.WriteLine("Subject: Can you save the day... again?");
                writer.WriteLine();
                writer.WriteLine("We’ve discovered the Swindler’s plan:");
                Console.WriteLine("Include forwarded email…");
                while (!reader.EndOfStream)
                {
                    string lineFromThePlan = reader.ReadLine();
                    writer.WriteLine("The plan -> " + lineFromThePlan);
                }
                writer.WriteLine();
                writer.WriteLine("Can you help us?");
                Console.WriteLine("Close writer");
                writer.Close();
                Console.WriteLine("Close reader");
                reader.Close();
                Console.WriteLine("Done");
            }
            catch
            {
                Console.WriteLine("The secret plan was stolen‼");
            }
        }
    }
}
