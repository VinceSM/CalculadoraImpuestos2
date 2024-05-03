using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraImpuestos.Model;

namespace CalculadoraImpuestos.Model
{
    public class TaxRate
    {
        public decimal GetTaxCalculator(string country, string state)
        {
            if (!string.IsNullOrEmpty(country) && string.IsNullOrEmpty(state))
            {
                return GetEUTax(country);
            }
            else if (!string.IsNullOrEmpty(state) && string.IsNullOrEmpty(country))
            {
                return GetUSTax(state);
            }

            return 0m;
        }

        private decimal GetEUTax(string country)
        {
            if (country == "España" || country == "Italia" || country == "Alemania")
            {
                return 0.20m; 
            }

            return 0m;
        }

        private decimal GetUSTax(string state)
        {
            if (state == "Mississippi" || state == "Texas" || state == "Kentucky")
            {
                return 0.07m; 
            }
            return 0m;
        }
    }
}
