using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Flyttefirma.Services
{
    public class FlyttePris
    {
        /// <summary>
        /// Calculates prices based on amount of hours and heavy items
        /// </summary>
        /// <param name="hours">Hours the move has taken</param>
        /// <param name="heavyItems">Amount of items over 30kg</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
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

            // Calculation for moves with hours greater then 7
            if (hours > 7)
            {
                // Rates and base values
                int baseHours = 7;
                double baseRate = 745;
                double discountRate = 700;
                double weightFee = 500;
                // Calcuations
                var hoursOverBaseHours = hours - baseHours;
                var basePrice = baseHours * baseRate;
                var discountPrice = hoursOverBaseHours * discountRate;
                var totalHourPrice = basePrice + discountPrice;
                var excessWeightPrice = heavyItems * weightFee;

                return totalHourPrice + excessWeightPrice;
            }

            // Calculation for moved with hours less than or equal to 7
            else
            {
                // Rates
                double baseRate = 745;
                double weightFee = 500;
                // Calculations
                var basePrice = hours * baseRate;
                var excessWeightPrice = heavyItems * weightFee;

                return basePrice + excessWeightPrice;
            }
        }
    }
}
