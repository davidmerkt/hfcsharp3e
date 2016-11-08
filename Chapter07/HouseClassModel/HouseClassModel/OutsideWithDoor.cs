using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseClassModel
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        { 
            DoorDescription = doorDescription;
        }

        //string DoorProperty { get; set; }

        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
        public override string Description
        {
            get
            {
                return base.Description + " You see " + DoorDescription + ".";
            }
        }
    }
}
