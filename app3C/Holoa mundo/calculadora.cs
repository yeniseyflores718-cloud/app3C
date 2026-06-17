using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app3C.Holoa_mundo
{
    public partial class frmcalculadora : Form
    {
        public frmcalculadora()
        {
            InitializeComponent();
        }
     

        private void calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnSumaar_Click(object sender, EventArgs e)
        {
            try
            {
                float valor1 = float.Parse(txtvaloor1.Text.Trim());
                float valor2 = float.Parse(txtValoor2.Text.Trim());
                float resultado = valor1 + valor2;
                lblResul.Text = "resultado: " + resultado;
                lblResul.Visible = true;

            } catch (Exception ex) 
            {
                MessageBox.Show("Se presento un error: "+ ex.Message);
            }
           

            
        }
    }
}
