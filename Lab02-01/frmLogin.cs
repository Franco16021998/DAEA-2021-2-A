using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            var Usuario = "Franco";
            var Password = "123456";
            if (txtUsuario.Text == Usuario && txtPassword.Text == Password)
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Cuenta incorrecta", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
