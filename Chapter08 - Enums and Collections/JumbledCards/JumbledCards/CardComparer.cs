using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumbledCards
{
    class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Face < y.Face)
                return -1;
            if (x.Face > y.Face)
                return 1;
            else
                return 0;
        }
    }
}
