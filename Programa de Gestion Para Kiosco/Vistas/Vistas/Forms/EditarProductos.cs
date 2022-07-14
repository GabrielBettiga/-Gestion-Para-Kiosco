using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using PagedList;

namespace Vistas.Forms
{
    public partial class EditarProductos : Form
    {
        NegocioProductos negpro = new NegocioProductos();
        int inicio = 1;
        public EditarProductos()
        {
            InitializeComponent();
            CargarTablaSinFiltro();
        }
        public void CargarTablaSinFiltro()
        {
            dataGridView2.DataSource = negpro.getListaPeoductos();
        }

        private void BTN_SIGUIENTE_Click(object sender, EventArgs e)
        {

        }

        private void BTN_ANTERIOR_Click(object sender, EventArgs e)
        {

        }
    }
}
