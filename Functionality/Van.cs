using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailLogic
{
    public class Van : Vehicle, IDrive
    {
        public Van()
        {
            fuel = 100;
            maxCapacity = 200;
            load = 0;
        }
        public override string Type
        {
            get
            {
                return "Van";
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
