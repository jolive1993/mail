using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailLogic
{
    public abstract class Pricing
    {
        public abstract string Type { get; }
        public double pricePerPound;
        public double calcTotalPrice(double totalWeight)
        {
            double totalPrice;
            totalPrice = totalWeight * pricePerPound;
            totalPrice = Math.Round(totalPrice, 2);
            return totalPrice;
        }
    }
}
