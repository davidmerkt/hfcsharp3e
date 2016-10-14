using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagement2
{
    class Bee
    {
        const double HoneyUnitsConsumedPerMg = .25;

        public double WeightMg { get; private set; }

        virtual public double HoneyConsumptionRate()
        {
            return HoneyUnitsConsumedPerMg * WeightMg;
        }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }
    }
}
