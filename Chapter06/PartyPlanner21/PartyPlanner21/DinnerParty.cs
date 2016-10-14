using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner21
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
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

        override public decimal Cost
        {
            get
            {
                decimal cost = base.Cost;

                cost += CalculateCostOfBeveragesPerPerson() * NumberOfPeople;

                if (HealthyOption)
                {
                    cost *= .95M;
                }

                return cost;
            }
        }
    }
}
