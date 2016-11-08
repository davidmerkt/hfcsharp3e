using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseClassModel
{
    class Outside : Location
    {
        //protected virtual string DoorDescription { get; set; }
        //protected virtual string DoorLocation { get; set; }
        private bool hot;

        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }

        public override string Description
        {
            get
            {
                string newDescription = base.Description;
                if(hot)
                {
                    newDescription += " It's very hot.";
                }
                return newDescription;
            }
        }
    }
}
