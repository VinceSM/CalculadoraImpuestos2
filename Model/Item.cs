using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Model
{
    public class Item
    {
        public int Quantity {  get; set; }
        public Producto Producto { get; set; }

        public Item(int Quantity, Producto producto) 
        {
            this.Quantity = Quantity;
            this.Producto = producto;
        }
    }
}
