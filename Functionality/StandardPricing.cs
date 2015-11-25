using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailLogic
{
    public class StandardPricing : Pricing
    {
        public StandardPricing()
        {
            pricePerPound = .5;
        }
        public override string Type
        {
            get
            {
                return "StandardPricing";
            }
        }
    }
}
