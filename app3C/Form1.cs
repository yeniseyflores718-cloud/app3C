using app3C.Holoa_mundo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app3C.cafeteria;

namespace app3C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            AbrirFormulario(new frmcalculadora(), "frmCalculadora");
        }

        private void cafeteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            AbrirFormulario(new frmCafeteria(), "frmCafeteria");
        }
        private void CerrarFormulariosHijos()
        {
            foreach (Form hijo in this.MdiChildren)
            {
                hijo.Close();
            }
        }
        private void AbrirFormulario(Form formulario, string nombreFormulario)
        {
            Form frm = Application.OpenForms[nombreFormulario];

            if (frm != null)
            {
                if (frm.WindowState == FormWindowState.Minimized)
                    frm.WindowState = FormWindowState.Normal;

                frm.Activate();
            }
            else
            {
                formulario.MdiParent = this;
                formulario.FormClosed += (s, args) => formulario.Dispose();
                formulario.Show();
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
