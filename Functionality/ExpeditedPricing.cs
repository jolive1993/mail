using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailLogic
{
    public class ExpeditedPricing : Pricing
    {
        public ExpeditedPricing()
        {
            pricePerPound = .75;
        }
        public override string Type
        {
            get
            {
                return "ExpeditedPricing";
            }
        }
    }
}

