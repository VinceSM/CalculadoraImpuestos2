using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Model
{
    public class Order
    {
        public List<Location> Locations { get; set; }
        public List<Item> Items { get; } = new List<Item>(); 

        public Order(List<Location> locations, List<Item> items)
        {
            Items = items;
            Locations = locations;
        }
        public decimal CalculateSubtotal()
        {
            decimal subtotal = 0m;

            foreach (var item in Items)
            {
                subtotal += item.Producto.Price * item.Quantity;
            }

            return subtotal;
        }
        public decimal CalculateTotal()
        {
            decimal subtotal = CalculateSubtotal();

            Location location = this.Locations.FirstOrDefault();

            TaxRate taxRate = new TaxRate();

            decimal taxRateValue = taxRate.GetTaxCalculator(location?.Country, location?.State);

            decimal total = subtotal * (1 + taxRateValue);

            return total;
        }
    }
}
