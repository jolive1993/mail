using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public double getWeight(int i)
        {
            double itemWeight;
            Console.WriteLine("What is the weight of item " + (i + 1) + "? (in lbs)");
            itemWeight = double.Parse(Console.ReadLine());
            return itemWeight;
        }
        public int getPricing()
        {
            int id;
            Console.WriteLine("Press 0 for standard, 1 for expedited, 2 for overnight");
            id = Int32.Parse(Console.ReadLine());
            return id;
        }
        public Dictionary<int, double> compileOrder(int numItems)
        {
            Dictionary<int, double> order = new Dictionary<int, double>();
            double weight;
            for (int i = 0; i < numItems; i++)
            {
                weight = getWeight(i);
                order.Add(i, weight);
            }
            return order;
        }
    }
}
