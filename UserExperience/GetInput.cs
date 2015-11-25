using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailLogic;

namespace UserExperience
{
    public class GetInput
    {
        int numItems = 0;
        public int getItemCount()
        {
            Console.WriteLine("How many items would you like to ship?");
            numItems = Int32.Parse(Console.ReadLine());
            return numItems;
        }
        public int getWeight(int i)
        {
            int itemWeight;
            Console.WriteLine("What is the weight of item " + (i + 1) + "? (in lbs)");
            itemWeight = Int32.Parse(Console.ReadLine());
            return itemWeight;
        }
        public int getPricing()
        {
            int id;
            Console.WriteLine("Press 0 for standard, 1 for expedited, 2 for overnight");
            id = Int32.Parse(Console.ReadLine());
            return id;
        }
        public Dictionary<int, int> compileOrder(int numItems)
        {
            Dictionary<int, int> order = new Dictionary<int, int>();
            int weight;
            for (int i = 0; i < numItems; i++)
            {
                weight = getWeight(i);
                order.Add(i, weight);
            }
            return order;
        }
    }
}
