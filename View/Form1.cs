using CalculadoraImpuestos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
            // Inicializa los ComboBox con los valores de StaticPersistence
            ElegirProducto.Items.AddRange(StaticPersistence.Productos.Select(p => p.Name).ToArray());
            cbCountry.Items.AddRange(StaticPersistence.Countries.Select(c => c.Country).ToArray());
            cbState.Items.AddRange(StaticPersistence.States.Select(s => s.State).ToArray());
        }

        private void ElegirProducto_SelectedItemChanged(object sender, EventArgs e)
        {
            var productoSeleccionado = ElegirProducto.SelectedItem as string;

            if (productoSeleccionado != null)
            {
                var producto = StaticPersistence.Productos.FirstOrDefault(p => p.Name == productoSeleccionado);

                if (producto != null)
                {
                    // Crea un ítem con cantidad 1 y el producto seleccionado
                    var item = new Item(1, producto);
                    currentOrder.Items.Add(item);

                    // Actualiza los valores de subtotal y total
                    ActualizarSubtotal();
                    ActualizarTotal();
                }
            }
        }

        private void ActualizarSubtotal()
        {
            // Calcula el subtotal y actualiza el TextBox
            decimal subtotal = currentOrder.CalculateSubtotal();
            txtSubtotal.Text = subtotal.ToString("C2");
        }

        private void ActualizarTotal()
        {
            // Calcula el total y actualiza el TextBox
            decimal total = currentOrder.CalculateTotal();
            txtTotal.Text = total.ToString("C2");
        }

        private void txtCantidadItem_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                string texto = textBox.Text;
                if (int.TryParse(texto, out int cantidad) && cantidad >= 0)
                {
                    var productoSeleccionado = ElegirProducto.SelectedItem as string;

                    if (productoSeleccionado != null)
                    {
                        var item = currentOrder.Items.FirstOrDefault(i => i.Producto.Name == productoSeleccionado);

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

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbState.Enabled = false;

            var countryName = cbCountry.SelectedItem as string;
            if (countryName != null)
            {
                var selectedCountry = StaticPersistence.Countries.FirstOrDefault(c => c.Country == countryName);

                if (selectedCountry != null)
                {
                    // Limpia y agrega la nueva ubicación en currentOrder.Locations
                    currentOrder.Locations.Clear();
                    currentOrder.Locations.Add(selectedCountry);

                    ActualizarTotal();
                }
            }
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCountry.Enabled = false;

            var stateName = cbState.SelectedItem as string;
            if (stateName != null)
            {
                var selectedState = StaticPersistence.States.FirstOrDefault(s => s.State == stateName);

                if (selectedState != null)
                {
                    currentOrder.Locations.Clear();
                    currentOrder.Locations.Add(selectedState);

                    ActualizarTotal();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbCountry.Enabled = true;
            cbState.Enabled = true;

            cbCountry.Text = string.Empty;
            cbState.Text = string.Empty;

            txtSubtotal.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtCantidadItem.Text = string.Empty;

            currentOrder.Items.Clear();
            currentOrder.Locations.Clear();
        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        { }
        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        { }
    }
}
