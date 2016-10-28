using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StingPatrolInterface
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Bee : IStingPatrol
        {
            public int AlertLevel { get; private set; }

            public int StingerLength { get; set; }

            public bool LookForEnemies()
            {
                return false;
            }

            public int SharpenStinger(int length)
            {
                return length;
            }
        }
    }
}
