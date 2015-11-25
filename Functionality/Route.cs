using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailLogic
{
    public class Route
    {
        public string destination = null;
        public string startingPoint = null;
        public string calcTransport(int totalWeight)
        {
            string result;
            if (totalWeight < 200)
            {
                result = "Van";
            }
            else
            {
                result = "Freight";
            }
            return result;
        }
    }
}
