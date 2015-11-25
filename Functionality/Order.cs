using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailLogic
{
    public class Order
    {
        public List<Mail> returnMailList(Dictionary<int, int> order)
        {
            List<Mail> sortedOrder = new List<Mail>();
            foreach (KeyValuePair<int, int> entry in order)
            {
                if (entry.Value > 5)
                {
                    sortedOrder.Add(new Package(entry.Value, entry.Key)); 
                }
                else
                {
                    sortedOrder.Add(new Envelope(entry.Value, entry.Key));
                }

            }
            return sortedOrder;
        }
        public int totalOrderWeight(Dictionary<int, int> order)
        {
            int totalWeight = 0;
            foreach (KeyValuePair<int, int> entry in order)
            {
                totalWeight += entry.Value; 
            }
            return totalWeight;
        }
    }
}
