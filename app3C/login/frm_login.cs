using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app3C.login
{
    public partial class frm_login : Form
    {
        private frm_login Principal;
        public frm_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuario = txt_user.Text.Trim();
            string password=txt_pw.Text.Trim();

            if (usuario=="Luis" && password =="Mendoza")
            {
                Form1 Principal = new Form1();
                Principal.Show();
                this.Hide();

            }else
            {
                lbl_leyenda.Text= "Credenciales incorrectas, intente de nuevo";
                lbl_leyenda.Visible = true;
                txt_user.Clear();
                txt_pw.Clear();
                //txt_user.Focus();

            }
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            lbl_leyenda.Visible= false;
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
