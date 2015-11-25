using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailLogic;

namespace ClassFactories
{
    public class TransportFactory
    {
        public Vehicle Get (string type)
        {
            switch(type)
            {
                case "Van":
                    return new Van();
                case "Freight":
                    return new Freight();
                default:
                    return new Van();
            }
        }
    }
}
