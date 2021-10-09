using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Negocio;

namespace Presentacion
{
    public partial class sd : Form
    {
        public sd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetAll();

            dgDatos.DataSource = dt;
            dgDatos.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.getByValue(txtBusqueda.Text);

            dgDatos.DataSource = dt;
            dgDatos.Refresh();
        }
    }
}
