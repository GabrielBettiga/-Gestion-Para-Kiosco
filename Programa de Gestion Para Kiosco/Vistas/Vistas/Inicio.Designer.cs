
namespace Vistas
{
    partial class BTNinicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTNinicio));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.LBLtitulo = new System.Windows.Forms.Label();
            this.PanelSombra = new System.Windows.Forms.Panel();
            this.PanelEscritorio = new System.Windows.Forms.Panel();
            this.IconoDeFormularioActual = new FontAwesome.Sharp.IconPictureBox();
            this.BTNreportes = new FontAwesome.Sharp.IconButton();
            this.BTNventas = new FontAwesome.Sharp.IconButton();
            this.BTNempleados = new FontAwesome.Sharp.IconButton();
            this.BTNcompras = new FontAwesome.Sharp.IconButton();
            this.BRNproductos = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.PanelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoDeFormularioActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.BTNreportes);
            this.panelMenu.Controls.Add(this.BTNventas);
            this.panelMenu.Controls.Add(this.BTNempleados);
            this.panelMenu.Controls.Add(this.BTNcompras);
            this.panelMenu.Controls.Add(this.BRNproductos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 631);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitulo.Controls.Add(this.LBLtitulo);
            this.panelTitulo.Controls.Add(this.IconoDeFormularioActual);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(979, 75);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // LBLtitulo
            // 
            this.LBLtitulo.AutoSize = true;
            this.LBLtitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.LBLtitulo.Location = new System.Drawing.Point(55, 32);
            this.LBLtitulo.Name = "LBLtitulo";
            this.LBLtitulo.Size = new System.Drawing.Size(45, 17);
            this.LBLtitulo.TabIndex = 1;
            this.LBLtitulo.Text = "Home";
            // 
            // PanelSombra
            // 
            this.PanelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.PanelSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSombra.Location = new System.Drawing.Point(220, 75);
            this.PanelSombra.Name = "PanelSombra";
            this.PanelSombra.Size = new System.Drawing.Size(979, 9);
            this.PanelSombra.TabIndex = 2;
            // 
            // PanelEscritorio
            // 
            this.PanelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.PanelEscritorio.Controls.Add(this.pictureBox2);
            this.PanelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEscritorio.Location = new System.Drawing.Point(220, 84);
            this.PanelEscritorio.Name = "PanelEscritorio";
            this.PanelEscritorio.Size = new System.Drawing.Size(979, 547);
            this.PanelEscritorio.TabIndex = 3;
            // 
            // IconoDeFormularioActual
            // 
            this.IconoDeFormularioActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IconoDeFormularioActual.ForeColor = System.Drawing.Color.MediumPurple;
            this.IconoDeFormularioActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconoDeFormularioActual.IconColor = System.Drawing.Color.MediumPurple;
            this.IconoDeFormularioActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoDeFormularioActual.Location = new System.Drawing.Point(17, 23);
            this.IconoDeFormularioActual.Name = "IconoDeFormularioActual";
            this.IconoDeFormularioActual.Size = new System.Drawing.Size(32, 35);
            this.IconoDeFormularioActual.TabIndex = 0;
            this.IconoDeFormularioActual.TabStop = false;
            // 
            // BTNreportes
            // 
            this.BTNreportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNreportes.FlatAppearance.BorderSize = 0;
            this.BTNreportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNreportes.ForeColor = System.Drawing.SystemColors.Window;
            this.BTNreportes.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.BTNreportes.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNreportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNreportes.IconSize = 32;
            this.BTNreportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNreportes.Location = new System.Drawing.Point(0, 380);
            this.BTNreportes.Name = "BTNreportes";
            this.BTNreportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BTNreportes.Size = new System.Drawing.Size(220, 60);
            this.BTNreportes.TabIndex = 6;
            this.BTNreportes.Text = "Reportes";
            this.BTNreportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNreportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNreportes.UseVisualStyleBackColor = true;
            this.BTNreportes.Click += new System.EventHandler(this.BTNreportes_Click);
            // 
            // BTNventas
            // 
            this.BTNventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNventas.FlatAppearance.BorderSize = 0;
            this.BTNventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNventas.ForeColor = System.Drawing.SystemColors.Window;
            this.BTNventas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.BTNventas.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNventas.IconSize = 32;
            this.BTNventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNventas.Location = new System.Drawing.Point(0, 320);
            this.BTNventas.Name = "BTNventas";
            this.BTNventas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BTNventas.Size = new System.Drawing.Size(220, 60);
            this.BTNventas.TabIndex = 5;
            this.BTNventas.Text = "Ventas";
            this.BTNventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNventas.UseVisualStyleBackColor = true;
            this.BTNventas.Click += new System.EventHandler(this.BTNventas_Click);
            // 
            // BTNempleados
            // 
            this.BTNempleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNempleados.FlatAppearance.BorderSize = 0;
            this.BTNempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNempleados.ForeColor = System.Drawing.SystemColors.Window;
            this.BTNempleados.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.BTNempleados.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNempleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNempleados.IconSize = 32;
            this.BTNempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNempleados.Location = new System.Drawing.Point(0, 260);
            this.BTNempleados.Name = "BTNempleados";
            this.BTNempleados.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BTNempleados.Size = new System.Drawing.Size(220, 60);
            this.BTNempleados.TabIndex = 4;
            this.BTNempleados.Text = "Empleados";
            this.BTNempleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNempleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNempleados.UseVisualStyleBackColor = true;
            this.BTNempleados.Click += new System.EventHandler(this.BTNempleados_Click);
            // 
            // BTNcompras
            // 
            this.BTNcompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNcompras.FlatAppearance.BorderSize = 0;
            this.BTNcompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNcompras.ForeColor = System.Drawing.SystemColors.Window;
            this.BTNcompras.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.BTNcompras.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNcompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNcompras.IconSize = 32;
            this.BTNcompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNcompras.Location = new System.Drawing.Point(0, 200);
            this.BTNcompras.Name = "BTNcompras";
            this.BTNcompras.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BTNcompras.Size = new System.Drawing.Size(220, 60);
            this.BTNcompras.TabIndex = 3;
            this.BTNcompras.Text = "Compras";
            this.BTNcompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNcompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNcompras.UseVisualStyleBackColor = true;
            this.BTNcompras.Click += new System.EventHandler(this.BTNcompras_Click);
            // 
            // BRNproductos
            // 
            this.BRNproductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BRNproductos.FlatAppearance.BorderSize = 0;
            this.BRNproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRNproductos.ForeColor = System.Drawing.SystemColors.Window;
            this.BRNproductos.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.BRNproductos.IconColor = System.Drawing.Color.Gainsboro;
            this.BRNproductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BRNproductos.IconSize = 32;
            this.BRNproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRNproductos.Location = new System.Drawing.Point(0, 140);
            this.BRNproductos.Name = "BRNproductos";
            this.BRNproductos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BRNproductos.Size = new System.Drawing.Size(220, 60);
            this.BRNproductos.TabIndex = 2;
            this.BRNproductos.Text = "Productos";
            this.BRNproductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRNproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BRNproductos.UseVisualStyleBackColor = true;
            this.BRNproductos.Click += new System.EventHandler(this.BRNproductos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(307, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(306, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BTNinicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 631);
            this.Controls.Add(this.PanelEscritorio);
            this.Controls.Add(this.PanelSombra);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "BTNinicio";
            this.Text = "Inicio";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.PanelEscritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconoDeFormularioActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton BRNproductos;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton BTNreportes;
        private FontAwesome.Sharp.IconButton BTNventas;
        private FontAwesome.Sharp.IconButton BTNempleados;
        private FontAwesome.Sharp.IconButton BTNcompras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox IconoDeFormularioActual;
        private System.Windows.Forms.Label LBLtitulo;
        private System.Windows.Forms.Panel PanelSombra;
        private System.Windows.Forms.Panel PanelEscritorio;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}