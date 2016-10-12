using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyFixed
{
    class DinnerParty
    {
        private const int costOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfDecorations() 
        {
            decimal costDecorations;

            if (FancyDecorations)
            {
                costDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                costDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            }

            return costDecorations; 
        }

        private decimal CalculateCostOfBeveragesPerPerson() 
        {
            decimal costBevPerPerson;

            if (HealthyOption)
            {
                costBevPerPerson = 5.00M;
            }
            else 
            {
                costBevPerPerson = 20.00M;
            }

            return costBevPerPerson;
        }

        public decimal Cost
        {
            get
            {
                decimal cost =
                    ((CalculateCostOfBeveragesPerPerson() + costOfFoodPerPerson) * NumberOfPeople) 
                    + CalculateCostOfDecorations();

                if (HealthyOption)
                {
                    cost *= .95M;
                }

                return cost;
            }
        }
    }
}
