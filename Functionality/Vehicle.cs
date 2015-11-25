using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailLogic
{
    public abstract class Vehicle
    {
        public abstract string Type { get; }
        public int fuel;
        public int maxCapacity;
        public int load;
    }
}
