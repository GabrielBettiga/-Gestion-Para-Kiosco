
namespace Vistas.Forms
{
    partial class Ventas
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
            this.lblCargarVenta = new System.Windows.Forms.Label();
            this.lblHistorialDeVenta = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHistorialDeVentas = new FontAwesome.Sharp.IconButton();
            this.btnCargarVenta = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.lblCargarVenta);
            this.panel1.Controls.Add(this.lblHistorialDeVenta);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 6;
            // 
            // lblCargarVenta
            // 
            this.lblCargarVenta.AutoSize = true;
            this.lblCargarVenta.Location = new System.Drawing.Point(427, 164);
            this.lblCargarVenta.Name = "lblCargarVenta";
            this.lblCargarVenta.Size = new System.Drawing.Size(116, 17);
            this.lblCargarVenta.TabIndex = 3;
            this.lblCargarVenta.Text = "CARGAR VENTA";
            this.lblCargarVenta.Visible = false;
            // 
            // lblHistorialDeVenta
            // 
            this.lblHistorialDeVenta.AutoSize = true;
            this.lblHistorialDeVenta.Location = new System.Drawing.Point(427, 164);
            this.lblHistorialDeVenta.Name = "lblHistorialDeVenta";
            this.lblHistorialDeVenta.Size = new System.Drawing.Size(153, 17);
            this.lblHistorialDeVenta.TabIndex = 2;
            this.lblHistorialDeVenta.Text = "HISTORIAL DE VENTA";
            this.lblHistorialDeVenta.Visible = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnHistorialDeVentas);
            this.panelMenu.Controls.Add(this.btnCargarVenta);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // btnHistorialDeVentas
            // 
            this.btnHistorialDeVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialDeVentas.FlatAppearance.BorderSize = 0;
            this.btnHistorialDeVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialDeVentas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHistorialDeVentas.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnHistorialDeVentas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHistorialDeVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorialDeVentas.IconSize = 32;
            this.btnHistorialDeVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialDeVentas.Location = new System.Drawing.Point(0, 357);
            this.btnHistorialDeVentas.Name = "btnHistorialDeVentas";
            this.btnHistorialDeVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHistorialDeVentas.Size = new System.Drawing.Size(220, 60);
            this.btnHistorialDeVentas.TabIndex = 3;
            this.btnHistorialDeVentas.Text = "Historial";
            this.btnHistorialDeVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialDeVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorialDeVentas.UseVisualStyleBackColor = true;
            this.btnHistorialDeVentas.Click += new System.EventHandler(this.btnHistorialDeVentas_Click);
            // 
            // btnCargarVenta
            // 
            this.btnCargarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargarVenta.FlatAppearance.BorderSize = 0;
            this.btnCargarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarVenta.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCargarVenta.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.btnCargarVenta.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCargarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarVenta.IconSize = 32;
            this.btnCargarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarVenta.Location = new System.Drawing.Point(0, 297);
            this.btnCargarVenta.Name = "btnCargarVenta";
            this.btnCargarVenta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCargarVenta.Size = new System.Drawing.Size(220, 60);
            this.btnCargarVenta.TabIndex = 2;
            this.btnCargarVenta.Text = "Cargar";
            this.btnCargarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarVenta.UseVisualStyleBackColor = true;
            this.btnCargarVenta.Click += new System.EventHandler(this.btnCargarVenta_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 297);
            this.panelLogo.TabIndex = 1;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCargarVenta;
        private System.Windows.Forms.Label lblHistorialDeVenta;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHistorialDeVentas;
        private FontAwesome.Sharp.IconButton btnCargarVenta;
        private System.Windows.Forms.Panel panelLogo;
    }
}