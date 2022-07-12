
namespace Vistas.Forms
{
    partial class EditarProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID_Proveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unidad_De_Medida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Punto_De_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio_De_Compra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio_De_Venta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL_Imagen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 569);
            this.panel1.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Proveedor,
            this.ID_Producto,
            this.ID_Categoria,
            this.Unidad_De_Medida,
            this.Descripcion,
            this.Stock,
            this.Punto_De_Pedido,
            this.Precio_De_Compra,
            this.Precio_De_Venta,
            this.URL_Imagen,
            this.Estado});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1227, 569);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID_Proveedor
            // 
            this.ID_Proveedor.Text = "ID_Proveedor";
            this.ID_Proveedor.Width = 106;
            // 
            // ID_Producto
            // 
            this.ID_Producto.Text = "ID_Producto";
            this.ID_Producto.Width = 90;
            // 
            // ID_Categoria
            // 
            this.ID_Categoria.Text = "ID_Categoria";
            this.ID_Categoria.Width = 93;
            // 
            // Unidad_De_Medida
            // 
            this.Unidad_De_Medida.Text = "Unidad_De_Medida";
            this.Unidad_De_Medida.Width = 138;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 93;
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            this.Stock.Width = 53;
            // 
            // Punto_De_Pedido
            // 
            this.Punto_De_Pedido.Text = "Punto_De_Pedido";
            this.Punto_De_Pedido.Width = 132;
            // 
            // Precio_De_Compra
            // 
            this.Precio_De_Compra.Text = "Precio_De_Compra";
            this.Precio_De_Compra.Width = 135;
            // 
            // Precio_De_Venta
            // 
            this.Precio_De_Venta.Text = "Precio_De_Venta";
            this.Precio_De_Venta.Width = 123;
            // 
            // URL_Imagen
            // 
            this.URL_Imagen.Text = "URL_Imagen";
            this.URL_Imagen.Width = 96;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            // 
            // EditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 569);
            this.Controls.Add(this.panel1);
            this.Name = "EditarProductos";
            this.Text = "EditarProductos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID_Proveedor;
        private System.Windows.Forms.ColumnHeader ID_Producto;
        private System.Windows.Forms.ColumnHeader ID_Categoria;
        private System.Windows.Forms.ColumnHeader Unidad_De_Medida;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.ColumnHeader Punto_De_Pedido;
        private System.Windows.Forms.ColumnHeader Precio_De_Compra;
        private System.Windows.Forms.ColumnHeader Precio_De_Venta;
        private System.Windows.Forms.ColumnHeader URL_Imagen;
        private System.Windows.Forms.ColumnHeader Estado;
    }
}