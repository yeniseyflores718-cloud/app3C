using Maquina_expendedora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app3C.maquina_expendedora
{
    public partial class frmMaquinaExpendedora : Form
    {
        producto p1;
        producto p2;
        producto p3;
        producto p4;
        public frmMaquinaExpendedora()
        {
            InitializeComponent();
            p1 = new producto("Boing", 18, 20);
            p2 = new producto("Gansito", 22, 15);
            p3 = new producto("Coca-Cola", 30, 10);
            p4 = new producto("Chetos", 20, 25);

            cboProducto.Items.Add(p1.nombre1);
            cboProducto.Items.Add(p2.nombre1);
            cboProducto.Items.Add(p3.nombre1);
            cboProducto.Items.Add(p4.nombre1);

            ActualizarVitrina();

        }
        private void ActualizarVitrina()
        {
            lblproducto1.Text = p1.nombre1;
            lblprecio1.Text = "$" + p1.precio1.ToString();
            lblstock1.Text = "Stock: " + p1.existencia1.ToString();
            lblproducto2.Text = p2.nombre1;
            lblprecio2.Text = "$" + p2.precio1.ToString();
            lblstock2.Text = "Stock: " + p2.existencia1.ToString();
            lblproducto3.Text = p3.nombre1;
            lblprecio3.Text = "$" + p3.precio1.ToString();
            lblstock3.Text = "Stock: " + p3.existencia1.ToString();
            lblproducto4.Text = p4.nombre1;
            lblprecio4.Text = "$" + p4.precio1.ToString();
            lblstock4.Text = "Stock: " + p4.existencia1.ToString();
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
        private void CalcularTotal()
        {
            double precio = 0;

            switch (cboProducto.SelectedIndex)
            {
                case 0:
                    precio = p1.precio1;
                    break;

                case 1:
                    precio = p2.precio1;
                    break;

                case 2:
                    precio = p3.precio1;
                    break;

                case 3:
                    precio = p4.precio1;
                    break;
            }

            lblTotal.Text = "$" + (precio * (int)nudCantidad.Value).ToString("N2");
        }

        private void btnCompar_Click(object sender, EventArgs e)
        {
            int cantidad = (int)nudCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("Seleccione una cantidad válida.");
                return;
            }

            double total = 0;

            switch (cboProducto.SelectedIndex)
            {
                case 0:
                    total = p1.comprar(cantidad);
                    break;

                case 1:
                    total = p2.comprar(cantidad);
                    break;

                case 2:
                    total = p3.comprar(cantidad);
                    break;

                case 3:
                    total = p4.comprar(cantidad);
                    break;
            }

            if (total == -1)
            {
                MessageBox.Show(
                    "No hay suficiente stock.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(
                    "Compra realizada.\n\nTotal a pagar: $" + total.ToString("N2"),
                    "Compra Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ActualizarVitrina();

                nudCantidad.Value = 0;
                lblTotal.Text = "$0.00";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblproducto1_Click(object sender, EventArgs e)
        {

        }
    }
}
