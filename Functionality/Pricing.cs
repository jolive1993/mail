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
        public double calcTotalPrice(int totalWeight)
        {
            double totalPrice;
            totalPrice = totalWeight * this.pricePerPound;
            return totalPrice;
        }
    }
}
