using Assignment3.Models;
using Assignment3.PaymentMethodStrategy;
using Assignment3.VariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.EshopContext
{
    public class EShop
    {
        private IEnumerable<IVariationStrategy> variations;
        private IPaymentMethodStrategy paymentMethods;

        public void SetPaymentMethid(IPaymentMethodStrategy method)
        {
            paymentMethods = method;
        }
        public void SetVariation(IEnumerable<IVariationStrategy> variationStrategies)
        {
            variations = variationStrategies;
        }
        public void CalculateCost(TShirt tshirt)
        {
            foreach (var variation in variations)
            {
                variation.Cost(tshirt);
            }
            Console.WriteLine($"T-Shirt final price is {tshirt.Price} euros");


        }

        public void PayTShirt(decimal price)
        {


            if (paymentMethods.Pay(price))
            {
                Console.WriteLine("Transaction was sucessful");
            }
            else
            {
                Console.WriteLine("Transaction aborted");
            }
        }


        public void Discount(TShirt tshirt, decimal? percentage)
        {
            paymentMethods.Discount(tshirt, percentage);
        }


    }
}
