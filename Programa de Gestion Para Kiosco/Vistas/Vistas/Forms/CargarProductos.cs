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
        ValidacionVacio val = new ValidacionVacio();


        public CargarProductos()
        {
            InitializeComponent();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {

            LBLvalidarCodigo.Text = "";
            LBLvalidarDescripcion.Text = "";
            LBLvalidarCategoria.Text = "";
            LBLvalidarPorcentaje.Text = "";
            LBLvalidarStock.Text = "";
            LBLvalidarPuntoDePedido.Text = "";

            String Codigo = textBoxCodigo.Text;
            if (val.CampoVacio(Codigo) == true)
            {
                LBLvalidarCodigo.Text = "*";
                LBLvalidarCodigo.ForeColor = System.Drawing.Color.Red;
            }
            String Descripcion = textBoxDescripcion.Text;
            if (val.CampoVacio(Descripcion) == true)
            {
                LBLvalidarDescripcion.Text = "*";
                LBLvalidarDescripcion.ForeColor = System.Drawing.Color.Red;
            }
            String Categoria = comboBoxCategoria.Text;
            if (val.CampoVacio(Categoria) == true)
            {
                LBLvalidarCategoria.Text = "*";
                LBLvalidarCategoria.ForeColor = System.Drawing.Color.Red;
            }
            String PorcentajeDeVenta = textBoxPorcentajeVenta.Text;
            if (val.CampoVacio(PorcentajeDeVenta) == true)
            {
                LBLvalidarPorcentaje.Text = "*";
                LBLvalidarPorcentaje.ForeColor = System.Drawing.Color.Red;
            }
            String Stock = textBoxStock.Text;
            if (val.CampoVacio(Stock) == true)
            {
                LBLvalidarStock.Text = "*";
                LBLvalidarStock.ForeColor = System.Drawing.Color.Red;
            }
            String PuntoDePedido = textBoxPuntoDePedido.Text;
            if (val.CampoVacio(PuntoDePedido) == true)
            {
                LBLvalidarPuntoDePedido.Text = "*";
                LBLvalidarPuntoDePedido.ForeColor = System.Drawing.Color.Red;
            }
            String URL = textBoxURL.Text;


            if (Codigo != "" && Descripcion != "" && Categoria != "" && PorcentajeDeVenta != "" && Stock != "" && PuntoDePedido != "" )
            {
                Producto pro = new Producto();
                pro.ID_Producto_P1 = Codigo;
                pro.Descripcion_P1 = Descripcion;
                pro.Categoria_P1 = Categoria;
                pro.Porcentaje_De_Venta_P1 = Convert.ToDecimal(PorcentajeDeVenta);
                pro.Stock_P1 = Convert.ToInt32(Stock);
                pro.Punto_De_Pedido_P1 = Convert.ToInt32(PuntoDePedido);
                pro.URL1 = URL;

                bool res = negpro.AgregarProducto(pro);


                textBoxCodigo.Text = "";
                LBLvalidarCodigo.Text = "";

                textBoxDescripcion.Text = "";
                LBLvalidarDescripcion.Text = "";

                comboBoxCategoria.Text = "";
                LBLvalidarCategoria.Text = "";

                textBoxPorcentajeVenta.Text = "";
                LBLvalidarPorcentaje.Text = "";

                textBoxStock.Text = "";
                LBLvalidarStock.Text = "";

                textBoxPuntoDePedido.Text = "";
                LBLvalidarPuntoDePedido.Text = "";

                textBoxURL.Text = "";

                if (res)
                {
                    LBLguardar.ForeColor = System.Drawing.Color.Green;
                    LBLguardar.Text = "SE GUARDO CON EXITO";
                }
                else
                {
                    LBLguardar.ForeColor = System.Drawing.Color.Red;
                    LBLguardar.Text = "EL CODIGO DE PRODUCTO YA EXISTE";
                }
            }

        }

        private void BTNbuscarImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxURL.Text = openFileDialog1.FileName;

                pictureBox1.Image = System.Drawing.Image.FromFile(textBoxURL.Text);
            }
        }
    }
}
