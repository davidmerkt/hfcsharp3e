using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowCalculator
{
    class Farmer
    {
        private int numberOfCows;

        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }

        public int BagsOfFeed { get; private set; }

        public int NumberOfCows
        {
            get { return numberOfCows; }
            set 
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }

        public int GetNumberOfCows() { return numberOfCows; }

        public void SetNumberOfCows(int newNumberOfCows)
        {
            numberOfCows = newNumberOfCows;
            BagsOfFeed = numberOfCows * FeedMultiplier;
        }

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }
    }
}
