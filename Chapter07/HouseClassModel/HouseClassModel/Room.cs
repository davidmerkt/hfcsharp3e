using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseClassModel
{
    class Room : Location
    {
        private string decoration;

        //protected virtual string DoorDescription { get; set; }
        //protected virtual string DoorLocation { get; set; }

        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return base.Description + " You see " + decoration + ".";
            }
        }
    }
}
