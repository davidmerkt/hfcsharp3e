using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX
{
    class Venus : PlanetMission
    {
        public Venus()
        {
            MilesToPlanet = 40000000;
            RocketFuelPerMile = 100000;
            RocketSpeedMPH = 25000;
        }

        public override void SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rocketSpeedMPH)
        {
            this.MilesToPlanet = milesToPlanet;
            this.RocketFuelPerMile = rocketFuelPerMile;
            this.RocketSpeedMPH = rocketSpeedMPH;
        }
    }

    class Mars : PlanetMission
    {
        public Mars()
        {
            MilesToPlanet = 75000000;
            RocketFuelPerMile = 100000;
            RocketSpeedMPH = 25000;
        }

        public override void SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rocketSpeedMPH)
        {
            this.MilesToPlanet = milesToPlanet;
            this.RocketFuelPerMile = rocketFuelPerMile;
            this.RocketSpeedMPH = rocketSpeedMPH;
        }
    }
}
