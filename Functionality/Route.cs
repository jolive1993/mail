using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionality
{
    public class Route
    {
        public string destination = null;
        public string startingPoint = null;
        public string calcTransport(int totalWeight)
        {
            string result;
            if (totalWeight < 100)
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
