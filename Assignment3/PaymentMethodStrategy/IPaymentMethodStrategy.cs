using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.PaymentMethodStrategy
{
    public interface IPaymentMethodStrategy
    {
        bool Pay(decimal amount);
        void Discount(TShirt tshirt, decimal? percentage);
    }
}
