using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallGuyApp
{
    class TallGuy : IClown 
    {
        public string Name;
        public int Height;
        public string FunnyThingIHave { get {return "big shoes";} }

        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is {0} and I'm {1} inches tall.", Name, Height);
        }

        public void Honk()
        {
            Console.WriteLine("Honk honk!");
        }
    }
}
