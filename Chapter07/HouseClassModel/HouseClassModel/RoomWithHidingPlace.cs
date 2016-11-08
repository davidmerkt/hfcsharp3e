using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseClassModel
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName)
            : base(name, decoration)
        {
            HidingPlace = hidingPlaceName;
        }

        public string HidingPlace { get; private set; }

        public override string Description
        {
            get
            {
                return base.Description + " Someone could hide " + HidingPlace + ".";
            }
        }
    }
}
