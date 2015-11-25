using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailLogic;

namespace ClassFactories
{
    public class PricingFactory
    {
        public Pricing Get (int id)
        {
            switch (id)
            {
                case 0:
                    return new StandardPricing();
                case 1:
                    return new ExpeditedPricing();
                case 2:
                    return new OvernightPricing();
                default:
                    return new StandardPricing();
            }
        }
    }
}
