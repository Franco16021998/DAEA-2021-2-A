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
    public partial class PrincipalMDI : Form
    {
        public PrincipalMDI()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuManUsuarios_Click(object sender, EventArgs e)
        {
            ManUsuario frm = new ManUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManProductos_Click(object sender, EventArgs e)
        {
            ManProductos frm1 = new ManProductos();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void mnuManCategorias_Click(object sender, EventArgs e)
        {
            ManCategorias frm = new ManCategorias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManProveedores_Click(object sender, EventArgs e)
        {
            ManProveedores frm = new ManProveedores();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
