using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.VariationStrategy
{
    public interface IVariationStrategy
    {
        void Cost(TShirt tshirt);
        

    }
}
