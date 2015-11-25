using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailLogic;
using UserExperience;
using ClassFactories;

namespace mail
{
    public class UserUseCase
    {
        public UserUseCase()
        {
            while (true)
            {
                Route route = new Route();
                GetInput input = new GetInput();
                Order userOrder = new Order();
                PricingFactory priceFactory = new PricingFactory();
                TransportFactory transportFactory = new TransportFactory();
                Pricing priceModel;
                Vehicle transportType;
                Dictionary<int, double> order;
                List<Mail> sortedOrder;
                int numItems;
                double totalWeight;
                int numPackages = 0;
                int numEnvelopes = 0;
                string transport;
                string quit;
                int priceModelId;
                double totalPrice;
                numItems = input.getItemCount();
                order = input.compileOrder(numItems);
                sortedOrder = userOrder.returnMailList(order);
                numPackages = userOrder.getNumPackage(sortedOrder);
                numEnvelopes = userOrder.getNumEnvelope(sortedOrder);
                Console.WriteLine("You're order contains " + numPackages + " packages and " + numEnvelopes + " envelopes");
                totalWeight = userOrder.totalOrderWeight(order);
                Console.WriteLine("You're total order weight is " + totalWeight);
                transport = route.calcTransport(totalWeight);
                transportType = transportFactory.Get(transport);
                Console.WriteLine("Your order will be shipped by " + transport);
                Console.WriteLine("Select your pricing model");
                priceModelId = input.getPricing();
                priceModel = priceFactory.Get(priceModelId);
                totalPrice = priceModel.calcTotalPrice(totalWeight);
                Console.WriteLine("The price for your order is $" + totalPrice);
                Console.WriteLine("Your order is complete, Press enter to fill another order or type 'quit' to quit");
                quit = Console.ReadLine();
                if (quit == "quit")
                {
                    break;
                }
            }
        }
    }
}

        