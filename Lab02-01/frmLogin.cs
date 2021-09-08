using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            SqlConnection cn = new SqlConnection("Server=FRANCO\\SQLEXPRESS2017; Database=db_lab03; Integrated Security=true");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT usuario_nombre,usuario_password FROM tbl_usuario WHERE usuario_nombre='" + txtUsuario.Text + "' and usuario_password= '" + txtPassword.Text + "'", cn);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                PrincipalMDI form1 = new PrincipalMDI();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de autentificación");
            }

        }

        private void login()
        {
            SqlConnection
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
