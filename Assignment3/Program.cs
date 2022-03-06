using Assignment3.Enums;
using Assignment3.EshopContext;
using Assignment3.Models;
using Assignment3.PaymentMethodStrategy;
using Assignment3.VariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        public static object TSshirt { get; private set; }

        static void Main(string[] args)
        {
            IEnumerable<IVariationStrategy> ShopNoramlVariations = new List<IVariationStrategy>()
            {

                new ColorVariationNormalStrategy(),
                new SizeVariationNormalStrategy(),
                new FabricVariationNormalStrategy()
            };
            TShirt shirt = new TShirt(Color.BLUE, Size.XS, Fabric.CASHMERE);
            var eshop = new EShop();
            eshop.SetVariation(ShopNoramlVariations);
            eshop.CalculateCost(shirt);

            //_____________Payment__________________//
            Console.WriteLine("Choose payment method");
            Console.WriteLine("1-Bank Transfer");
            Console.WriteLine("2-Cash");
            Console.WriteLine("3-Debit");
            Console.WriteLine("4-Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":eshop.SetPaymentMethid(new BankTransferStrategy());break;
                case "2":eshop.SetPaymentMethid(new CashStrategy());break;
                case "3":eshop.SetPaymentMethid(new DebitCardStrategy());break;
                case "4": Console.WriteLine("User exiting application"); ;break;
                default: Console.WriteLine("Invalid input");break;


            }

            eshop.Discount(shirt, 0.050m);

            eshop.PayTShirt(shirt.Price);
        }
    }
}
