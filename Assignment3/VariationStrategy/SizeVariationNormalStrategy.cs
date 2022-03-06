using Assignment3.Enums;
using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.VariationStrategy
{
    internal class SizeVariationNormalStrategy : IVariationStrategy
    {
        private static Dictionary<Size, decimal> sizeVariations;
        static SizeVariationNormalStrategy()
        {
            sizeVariations = new Dictionary<Size, decimal>()
            {
                {Size.XS,3m },
                {Size.S,4m },
                {Size.M,7m },
                {Size.L,13m },
                {Size.XL,15m },
                {Size.XXL,16m },
                {Size.XXXL,20m }

            };
        }
        public void Cost(TShirt tshirt)
        {
            tshirt.Price += sizeVariations[tshirt.Size];
        }

   
    }
}
