using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocios;
using Entidades;
using System.Windows.Forms;

namespace Vistas.Forms
{
    public partial class CargarProductos : Form
    {
        NegocioProductos negpro = new NegocioProductos();


        public CargarProductos()
        {
            InitializeComponent();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            String Codigo = textBoxCodigo.Text;
            String Descripcion = textBoxDescripcion.Text;
            String Categoria = comboBoxCategoria.Text;
            String PorcentajeDeVenta = textBoxPorcentajeVenta.Text;
            String Stock = textBoxStock.Text;
            String PuntoDePedido = textBoxPuntoDePedido.Text;
            String URL = textBoxURL.Text;

            Producto pro = new Producto();
            pro.ID_Producto_P1= Codigo;
            pro.Descripcion_P1 = Descripcion;
            pro.Categoria_P1 = Categoria;
            pro.Porcentaje_De_Venta_P1 = Convert.ToDecimal(PorcentajeDeVenta);
            pro.Stock_P1 = Convert.ToInt32(Stock);
            pro.Punto_De_Pedido_P1 = Convert.ToInt32(PuntoDePedido);
            pro.URL1 = URL;

            negpro.AgregarProducto(pro);

            textBoxCodigo.Text = "";
            textBoxDescripcion.Text = "";
            comboBoxCategoria.Text = "";
            textBoxPorcentajeVenta.Text = "";
            textBoxStock.Text = "";
            textBoxPuntoDePedido.Text = "";
            textBoxURL.Text = "";


        }
    }
}
