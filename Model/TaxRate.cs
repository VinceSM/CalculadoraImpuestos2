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
        public decimal GetTaxCalculator(string State, string Country) 
        {
            if(Country != null && State == null)
            {
                GetEUTax(Country);
            }
            else 
            {
                GetUSTax(State);
            }
            return 0m;
        }

        private decimal GetEUTax(string Country)
        {
            if (Country == "España(Country)" ||  Country == "Italia(Country)" || Country == "Alemania(Country)")
            {
                return 0.20m;
            }
            return 0m;
        }
        private decimal GetUSTax(string State)
        {
            if(State == "Mississippi(State)" || State == "Texas(State)" || State == "Kentucky(State)")
            {
                return 0.07m;
            }
            return 0m;
        }
    }
}
