using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailLogic
{
    public class Freight : Vehicle, IDrive
    {
        public Freight()
        {
            fuel = 200;
            maxCapacity = 1000;
            load = 0;
        }
        public override string Type
        {
            get
            {
                return "Freight";
            }
        }
        public void refuel()
        {

        }
        public void deliver()
        {

        }
    }
}
