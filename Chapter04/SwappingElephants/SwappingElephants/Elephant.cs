using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwappingElephants
{
    class Elephant
    {
        public int IntEarSize;
        public string StrName;

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + IntEarSize + " inches tall", StrName + " says…");
        }

        public void TellMe(string strMessage, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.StrName + " says: " + strMessage);
        }

        public void SpeakTo(Elephant whoToTalkTo, string strMessage)        
        {
            whoToTalkTo.TellMe(strMessage, this);
        }
    }
}
