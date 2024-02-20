using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    internal class CurrencyConverter
    {
        private static double conversionRate = 0.51129; // Conversion rate from BGN to EUR as of Feb 20, 2024

        public static double ConvertToEUR(double bgn)
        {
            return Math.Round(bgn * conversionRate, 2);
        }

        public static double ConvertToBGN(double eur)
        {
            return Math.Round(eur / conversionRate, 2);
        }
    }
}
