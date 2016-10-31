using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX
{
    abstract class PlanetMission
    {
        public long RocketFuelPerMile;
        public long RocketSpeedMPH;
        public int MilesToPlanet;

        public long UnitsOfFuelNeeded()
        {
            return MilesToPlanet * RocketFuelPerMile;
        }

        public int TimeNeeded()
        {
            return MilesToPlanet / (int)RocketSpeedMPH;
        }

        public string FuelNeeded()
        {
            return "You'll need " + UnitsOfFuelNeeded() + " units of fuel to get there.\n" +
                "I will take " + TimeNeeded() + " hours.";
        }

        public abstract void SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rocketSpeedMPH);
    }
}
