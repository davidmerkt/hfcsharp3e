using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallGuyApp
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;

        public string ScaryThingIHave
        {
            get { return numberOfScaryThings.ToString() + " spiders"; }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Boo‼ Gotcha‼");
            Console.WriteLine("You can't have my {0}", base.funnyThingIHave);
        }

        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
    }
}
