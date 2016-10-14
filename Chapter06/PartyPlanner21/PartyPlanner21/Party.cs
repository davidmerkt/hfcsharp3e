using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner21
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

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

        virtual public decimal Cost
        {
            get
            {
                decimal cost = CostOfFoodPerPerson * NumberOfPeople + CalculateCostOfDecorations();

                if (NumberOfPeople > 12)
                    cost += 100.00M;

                return cost;
            }
        }
    }
}
