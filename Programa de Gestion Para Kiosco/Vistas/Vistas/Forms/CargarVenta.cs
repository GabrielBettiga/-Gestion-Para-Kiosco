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
using Entidades;

namespace Vistas.Forms
{
    public partial class CargarVenta : Form
    {
        public CargarVenta()
        {
            InitializeComponent();
        }

        private void numericUpDown_CANTIDAD_PRODUCTO_Enter(object sender, EventArgs e)
        {
            AGREGAR_PRODUCTO();
        }

        private void AGREGAR_PRODUCTO()
        {
            
            NegocioProductos negpro = new NegocioProductos();
            DataTable tabla_producto = negpro.BuscarProductoPorID(TXT_CODIGO_PRODUCTO.Text);
        
            GridView_productosXcomprar.DataSource = tabla_producto;

            
            
        }

        /*private void TXT_CODIGO_PRODUCTO_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Producto pro = new Producto();
                NegocioProductos negpro = new NegocioProductos();
                DataTable tabla_producto = negpro.BuscarProductoPorID(TXT_CODIGO_PRODUCTO.Text);
                bool producto_existe = false;

                

            }
        }*/
    }
}
