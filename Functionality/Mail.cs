using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionality
{
    public abstract class Mail
    {
        public int weight;
        public int id;
        public int getWeight()
        {
            int weight;
            weight = this.weight;
            return weight;
        }
    }
}
