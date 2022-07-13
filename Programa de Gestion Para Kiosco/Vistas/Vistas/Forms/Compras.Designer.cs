
namespace Vistas.Forms
{
    partial class Compras
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
            this.SUBpanel = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHistorialDeCompra = new FontAwesome.Sharp.IconButton();
            this.btnCargarCompra = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SUBpanel.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.SUBpanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 6;
            // 
            // SUBpanel
            // 
            this.SUBpanel.AutoScroll = true;
            this.SUBpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.SUBpanel.Controls.Add(this.panelMenu);
            this.SUBpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SUBpanel.Location = new System.Drawing.Point(0, 0);
            this.SUBpanel.Name = "SUBpanel";
            this.SUBpanel.Size = new System.Drawing.Size(800, 450);
            this.SUBpanel.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnHistorialDeCompra);
            this.panelMenu.Controls.Add(this.btnCargarCompra);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // btnHistorialDeCompra
            // 
            this.btnHistorialDeCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialDeCompra.FlatAppearance.BorderSize = 0;
            this.btnHistorialDeCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialDeCompra.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHistorialDeCompra.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnHistorialDeCompra.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHistorialDeCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorialDeCompra.IconSize = 32;
            this.btnHistorialDeCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialDeCompra.Location = new System.Drawing.Point(0, 235);
            this.btnHistorialDeCompra.Name = "btnHistorialDeCompra";
            this.btnHistorialDeCompra.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHistorialDeCompra.Size = new System.Drawing.Size(220, 60);
            this.btnHistorialDeCompra.TabIndex = 3;
            this.btnHistorialDeCompra.Text = "Historial";
            this.btnHistorialDeCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialDeCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorialDeCompra.UseVisualStyleBackColor = true;
            this.btnHistorialDeCompra.Click += new System.EventHandler(this.btnHistorialDeCompra_Click);
            // 
            // btnCargarCompra
            // 
            this.btnCargarCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargarCompra.FlatAppearance.BorderSize = 0;
            this.btnCargarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCompra.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCargarCompra.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.btnCargarCompra.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCargarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarCompra.IconSize = 32;
            this.btnCargarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarCompra.Location = new System.Drawing.Point(0, 175);
            this.btnCargarCompra.Name = "btnCargarCompra";
            this.btnCargarCompra.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCargarCompra.Size = new System.Drawing.Size(220, 60);
            this.btnCargarCompra.TabIndex = 2;
            this.btnCargarCompra.Text = "Cargar";
            this.btnCargarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarCompra.UseVisualStyleBackColor = true;
            this.btnCargarCompra.Click += new System.EventHandler(this.btnCargarCompra_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 175);
            this.panelLogo.TabIndex = 1;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Compras";
            this.Text = "Compras";
            this.panel1.ResumeLayout(false);
            this.SUBpanel.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SUBpanel;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnCargarCompra;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnHistorialDeCompra;
    }
}