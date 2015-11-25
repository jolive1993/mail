using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailLogic
{
    public class Order
    {
        public List<Mail> returnMailList(Dictionary<int, double> order)
        {
            List<Mail> sortedOrder = new List<Mail>();
            foreach (KeyValuePair<int, double> entry in order)
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
        public double totalOrderWeight(Dictionary<int, double> order)
        {
            double totalWeight = 0;
            foreach (KeyValuePair<int, double> entry in order)
            {
                totalWeight += entry.Value;
            }
            return totalWeight;
        }
        public int getNumPackage(List<Mail> sortedOrder)
        {
            int numPackages = 0;
            foreach (Mail obj in sortedOrder)
            {
                if (obj is Package)
                {
                    numPackages += 1;
                }
            }
            return numPackages;
        }
        public int getNumEnvelope(List<Mail> sortedOrder)
        {
            int numEnvelope = 0;
            foreach (Mail obj in sortedOrder)
            {
                if (obj is Envelope)
                {
                    numEnvelope += 1;
                }
            }
            return numEnvelope;
        }
    }
}

