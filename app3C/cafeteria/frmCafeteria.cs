using app3C.cafeteria;
using El_simulador_de_la_cafeteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app3C.cafeteria
{
    public partial class frmCafeteria : Form
    {
        private List<bebida> bebidas;
        public frmCafeteria()
        {
            InitializeComponent();
            bebidas = new List<bebida>();

        }

        private void frmCafeteria_Load(object sender, EventArgs e)
        {
            checkBox1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdbCaliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCaliente.Checked ==true)
            {
                lblExtra.Text = "Temperatura";
                checkBox1.Visible = false;
            }
            else 
            {
                lblExtra.Text = "Cantidad de hielo";
                checkBox1.Visible = false;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre=txtNombreBebida.Text;
            float precio= float.Parse(txtPrecio.Text.Trim());
            string tamaño=cboTamaño.Text;
            int extra =int.Parse( txtExtra.Text.Trim());


            if (rdbCaliente.Checked ==true)
            {
                bebidas.Add(new BebidaCaliente(nombre,tamaño,precio,extra));

            }
            else if (rdbAlcoholica.Checked == true)
            {
                string gluten;

                if (checkBox1.Checked)
                {
                    gluten = "Sí";
                }
                else
                {
                    gluten = "No";
                }
                bebidas.Add(new BebidaAlcoholica(nombre, tamaño, precio, extra, gluten));
            }
            else if (rdbFria.Checked == true)
            {
                bebidas.Add(new BebidaFria(nombre, tamaño, precio, extra));
            }

            MessageBox.Show("bebida registrada correctamente, tienes: " + bebidas.Count + " bebidas registradas");
            limpiar();  

            if (bebidas[bebidas.Count-1] is BebidaFria fria)
            {
                lsbLista.Items.Add(fria.listar());
            }
            else if (bebidas[bebidas.Count-1] is BebidaCaliente caliente)
            {
                lsbLista.Items.Add(caliente.listar());
            }
            else if (bebidas[bebidas.Count - 1] is BebidaAlcoholica alcoholica)
            {
                lsbLista.Items.Add(alcoholica.listar());
            }
                lblCantidad.Text = bebidas.Count.ToString() + " bebidas registradas ";
        }
        private void limpiar()
        {
            txtNombreBebida.Clear();
            txtPrecio.Clear();
            txtExtra.Clear();
            cboTamaño.SelectedIndex=-1;
            rdbFria.Checked = false;
            rdbCaliente.Checked = false;
            rdbAlcoholica.Checked = false;

            checkBox1.Checked = false;
            checkBox1.Visible = false;
        }

        private void lsbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblDescripcion.Text = bebidas[lsbLista.SelectedIndex].preparar();
            rctDescripcion.Text = bebidas[lsbLista.SelectedIndex].preparar();
            
        }

        private void rdbAlcoholica_CheckedChanged(object sender, EventArgs e)
            {
            if (rdbAlcoholica.Checked == true)
            {
                lblExtra.Text = "Porcentaje  de alcohol";
                checkBox1.Visible = true;   

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreBebida.Clear();
            txtPrecio.Clear();
            txtExtra.Clear();
            cboTamaño.SelectedIndex = -1;
            lsbLista.Items.Clear();
            rctDescripcion.Clear();
            lblCantidad.Text = "Total de bebidas";
            bebidas.Clear();
            rdbFria.Checked = false;
            rdbCaliente.Checked = false;
            rdbAlcoholica.Checked = false;

            checkBox1.Checked = false;
            checkBox1.Visible = false;
        }
    }
}
