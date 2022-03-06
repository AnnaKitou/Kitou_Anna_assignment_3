using Assignment3.Enums;
using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.VariationStrategy
{
    public class FabricVariationNormalStrategy : IVariationStrategy
    {
        private static Dictionary<Fabric, decimal> fabricVariations;
        static FabricVariationNormalStrategy()
        {
            fabricVariations = new Dictionary<Fabric, decimal>()
            {
                {Fabric.CASHMERE,3m },
                {Fabric.COTTON,2m },
                {Fabric.LINEN,7m },
                {Fabric.POLYESTER,13m },
                {Fabric.RAYON,15m },
                {Fabric.SILK,16m },
                {Fabric.WOOL,20m }

            };
        }
        public void Cost(TShirt tshirt)
        {
            tshirt.Price += fabricVariations[tshirt.Fabric];
        }

    }
    
}
