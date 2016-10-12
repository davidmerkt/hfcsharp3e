using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner2
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public string CakeWriting { get; set; }

        public decimal Cost 
        {
            get
            {
                decimal totalCost = calculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
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

        private decimal calculateCostOfDecorations()
        {
            decimal costOfDecorations;

            if (FancyDecorations) 
                costOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            else 
                costOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;

            return costOfDecorations;
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
