﻿
namespace Vistas.Forms
{
    partial class Productos
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
            this.PanelEscritorio = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnCargarProducto = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.LBLcarga = new System.Windows.Forms.Label();
            this.LBLeditar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEscritorio
            // 
            this.PanelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.PanelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEscritorio.Location = new System.Drawing.Point(0, 0);
            this.PanelEscritorio.Name = "PanelEscritorio";
            this.PanelEscritorio.Size = new System.Drawing.Size(800, 450);
            this.PanelEscritorio.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.LBLeditar);
            this.panel1.Controls.Add(this.LBLcarga);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnEditar);
            this.panelMenu.Controls.Add(this.btnCargarProducto);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnEditar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 32;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(0, 181);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEditar.Size = new System.Drawing.Size(220, 60);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargarProducto.FlatAppearance.BorderSize = 0;
            this.btnCargarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarProducto.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCargarProducto.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.btnCargarProducto.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCargarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarProducto.IconSize = 32;
            this.btnCargarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarProducto.Location = new System.Drawing.Point(0, 121);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCargarProducto.Size = new System.Drawing.Size(220, 60);
            this.btnCargarProducto.TabIndex = 2;
            this.btnCargarProducto.Text = "Cargar";
            this.btnCargarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 121);
            this.panelLogo.TabIndex = 1;
            // 
            // LBLcarga
            // 
            this.LBLcarga.AutoSize = true;
            this.LBLcarga.Location = new System.Drawing.Point(427, 121);
            this.LBLcarga.Name = "LBLcarga";
            this.LBLcarga.Size = new System.Drawing.Size(171, 17);
            this.LBLcarga.TabIndex = 2;
            this.LBLcarga.Text = "CARGA DE PRODUCTOS";
            this.LBLcarga.Visible = false;
            // 
            // LBLeditar
            // 
            this.LBLeditar.AutoSize = true;
            this.LBLeditar.Location = new System.Drawing.Point(427, 121);
            this.LBLeditar.Name = "LBLeditar";
            this.LBLeditar.Size = new System.Drawing.Size(178, 17);
            this.LBLeditar.TabIndex = 3;
            this.LBLeditar.Text = "EDICION DE PRODUCTOS";
            this.LBLeditar.Visible = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelEscritorio);
            this.Name = "Productos";
            this.Text = "Productos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelEscritorio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnCargarProducto;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label LBLeditar;
        private System.Windows.Forms.Label LBLcarga;
    }
}