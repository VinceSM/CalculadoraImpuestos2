using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Model
{
    public class Location
    {
        public string State { get; private set; }
        
        public string Country { get; private set; }

        public Location(string country = null , string state = null)
        {
            Country = country;
            State = state;
        }
    }
}
