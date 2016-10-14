using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner21
{
    class BirthdayParty : Party
    {
        public string CakeWriting { get; set; }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost;

                if (cakeSize() == 8)
                    cakeCost = 40.00M + ActualLength * .25M;
                else
                    cakeCost = 75.00M + ActualLength * .25M;

                return totalCost + cakeCost;
            }
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > maxWritingLength()) return true;
                else return false;
            }
        }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > maxWritingLength()) return maxWritingLength();
                else return CakeWriting.Length;
            }
        }

        private int cakeSize()
        {
            if (NumberOfPeople <= 4) return 8;
            else return 16;
        }

        private int maxWritingLength()
        {
            if (cakeSize() == 8) return 16;
            else return 40;
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
    }
}
