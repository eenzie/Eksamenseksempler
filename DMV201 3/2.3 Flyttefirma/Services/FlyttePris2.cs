using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Flyttefirma.Services
{
    internal class FlyttePris2
    {
        public static double CalculateRemovalPrice(int hours, int heavyItems)
        {
            // Throws exception if hours are negative or equal to zero
            if (hours <= 0)
            {
                throw new ArgumentException("Hours must be greater than zero");
            }

            // Throws exception if heavy item are negative
            if (heavyItems < 0)
            {
                throw new ArgumentException("Heavy items must be greater than or equal to zero");
            }

            int baseHours = 7;
            double baseRate = 745;
            double discountRate = 700;
            double weightFee = 500;

            double totalHourPrice = 0;

            // Hour price calculation for moves with hours greater than 7
            if (hours > 7)
            {
                var hoursOverBaseHours = hours - baseHours;
                var discountPrice = hoursOverBaseHours * discountRate;
                var baseHourPrice = baseHours * baseRate;
                totalHourPrice = baseHourPrice + discountPrice;
            }
            // Hour price calculation for moves with hours less than or equal to 7
            else
            {
                totalHourPrice = hours * baseRate;
            }

            // Calculates fee for heavy items
            var excessWeightPrice = heavyItems * weightFee;

            // Calculates total price of the move
            return totalHourPrice + excessWeightPrice;
        }
    }
}
