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
using Entidades;

namespace Vistas.Forms
{
    public partial class EditarProductos : Form
    {
        NegocioProductos negpro = new NegocioProductos();
        Paginacion obj = new Paginacion();

        int varPagInicio = 1;
        int varPagIndice = 0;
        int totalFilasMostrar = 10;
        int varPagFinal;
        public EditarProductos()
        {
            InitializeComponent();
            varPagFinal = totalFilasMostrar;
            CargarTablaSinFiltro();
        }
        public void CargarTablaSinFiltro()
        {
            obj.VarDatoInicio1 = varPagInicio;
            obj.VarDatoFin1 = varPagFinal;
            dataGridView2.DataSource=negpro.ListarProductos(obj);
        }

        private void BTN_SIGUIENTE_Click(object sender, EventArgs e)
        {
            varPagInicio += 10;
            varPagFinal += 10;
            obj.VarDatoInicio1 = varPagInicio;
            obj.VarDatoFin1 = varPagFinal;
            dataGridView2.DataSource = negpro.ListarProductos(obj);
        }

        private void BTN_ANTERIOR_Click(object sender, EventArgs e)
        {
            varPagInicio -= 10;
            varPagFinal -= 10;
            obj.VarDatoInicio1 = varPagInicio;
            obj.VarDatoFin1 = varPagFinal;
            dataGridView2.DataSource = negpro.ListarProductos(obj);
        }
    }
}
