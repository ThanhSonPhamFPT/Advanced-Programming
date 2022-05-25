using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class PriceCalculator
    {
        public static decimal CalculatePrice(decimal pricePerDay, int numberOfDays, Season season, Discount discount)
        {
            int multiplier = (int)season;
            decimal discountMultiplier = (decimal)discount / 100;
            decimal priceBeforeDiscount = numberOfDays * pricePerDay * multiplier;
            decimal discountedAmount =
              priceBeforeDiscount * discountMultiplier;
            decimal finalPrice = priceBeforeDiscount - discountedAmount;
            return finalPrice;
        }
    }

}
