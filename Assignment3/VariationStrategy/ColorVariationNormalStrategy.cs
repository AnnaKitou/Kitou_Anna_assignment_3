using Assignment3.Enums;
using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.VariationStrategy
{
    public class ColorVariationNormalStrategy : IVariationStrategy
    {
        private static Dictionary<Color, decimal> colorVariations;
        static ColorVariationNormalStrategy()
        {
            colorVariations = new Dictionary<Color, decimal>()
            {
                {Color.BLUE,1m },
                {Color.GREEN,2m },
                {Color.INDIGO,4m },
                {Color.ORANGE,5m },
                {Color.RED,8m },
                {Color.VIOLET,12m },
                {Color.YELLOW,20m }

            };
        }
        public void Cost(TShirt tshirt)
        {
        tshirt.Price += colorVariations[tshirt.Color];
        }
    }
}
