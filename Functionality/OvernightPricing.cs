using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailLogic
{
    public class OvernightPricing : Pricing
    {
        public OvernightPricing()
        {
            pricePerPound = 1.05;
        }
        public override string Type
        {
            get
            {
                return "OvernightPricing";
            }
        }
    }
}

