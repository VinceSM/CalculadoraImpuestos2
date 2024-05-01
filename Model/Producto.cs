using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Model
{
    public class Producto
    {
        public string Name { get; private set; } 
        public decimal Price { get; private set; } 
        public Producto(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
