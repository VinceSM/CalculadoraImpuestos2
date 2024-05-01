using CalculadoraImpuestos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraImpuestos
{
    public partial class Form1 : Form
    {
        private Order currentOrder;

        public Form1()
        {
            InitializeComponent();
            currentOrder = new Order(new List<Location>(), new List<Item>());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeControls();
        }
        private void InitializeControls()
        {
            ElegirProducto.Items.AddRange(new string[] { "COCA-COLA", "SPRITE", "FANTA" });

            ElegirPaisEstado.Items.AddRange(new string[] { "España(Country)", "Italia(Country)", "Alemania(Country)",
                "Mississippi(State)", "Kentucky(State)", "Texas(State)" });
        }

        private void ElegirProducto_SelectedItemChanged(object sender, EventArgs e)
        {
            var productoSeleccionado = ElegirProducto.SelectedItem as string;

            if (productoSeleccionado != null)
            {
                var producto = StaticPersistence.Productos.Find(p => p.Name == productoSeleccionado);

                if (producto != null)
                {
                    currentOrder.Items.Add(new Item(1, producto));

                    ActualizarSubtotal();
                }
            }
        }
        private void ElegirPaisEstado_SelectedItemChanged(object sender, EventArgs e)
        {
            var seleccionActual = ElegirPaisEstado.SelectedItem as string;

            if (seleccionActual != null)
            {
                Location selectedLocation = null;

                if (seleccionActual.EndsWith("(Country)"))
                {
                    selectedLocation = StaticPersistence.Countries.Find(c => c.Country == seleccionActual);
                }
                else if (seleccionActual.EndsWith("(State)"))
                {
                    selectedLocation = StaticPersistence.States.Find(s => s.State == seleccionActual);
                }
                if (selectedLocation != null)
                {
                    currentOrder.Locations.Clear();
                    currentOrder.Locations.Add(selectedLocation);

                    ActualizarTotal();
                }
            }
        }

        private void ActualizarSubtotal()
        {
            decimal subtotal = currentOrder.CalculateSubtotal();
            txtSubtotal.Text = subtotal.ToString("C2");
        }
        private void ActualizarTotal()
        {
            decimal total = currentOrder.CalculateTotal();

            txtTotal.Text = total.ToString("C2");
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidadItem_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                string texto = textBox.Text;
                if (int.TryParse(texto, out int cantidad))
                {
                    var productoSeleccionado = ElegirProducto.SelectedItem as string;

                    if (productoSeleccionado != null)
                    {
                        var item = currentOrder.Items.FirstOrDefault(i => i.Producto.Name == 
                        productoSeleccionado);

                        if (item != null)
                        {
                            item.Quantity = cantidad;

                            ActualizarSubtotal();
                            ActualizarTotal();
                        }
                    }
                }
            }
        }

        private void txtCantidadItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActualizarSubtotal();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidadItem.Text = "";
            txtSubtotal.Text = "";
            txtTotal.Text = "";

            ElegirProducto.SelectedItem = "";
            ElegirPaisEstado.SelectedItem = "";
        }
    }

}
