﻿
namespace Vistas.Forms
{
    partial class Empleados
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEditarEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnCargarEmpleado = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblCargarUsuario = new System.Windows.Forms.Label();
            this.lblEditarUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.lblEditarUsuario);
            this.panel1.Controls.Add(this.lblCargarUsuario);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 6;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnEditarEmpleado);
            this.panelMenu.Controls.Add(this.btnCargarEmpleado);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEditarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditarEmpleado.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnEditarEmpleado.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEditarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarEmpleado.IconSize = 32;
            this.btnEditarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarEmpleado.Location = new System.Drawing.Point(0, 295);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEditarEmpleado.Size = new System.Drawing.Size(220, 60);
            this.btnEditarEmpleado.TabIndex = 3;
            this.btnEditarEmpleado.Text = "Editar";
            this.btnEditarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarEmpleado.UseVisualStyleBackColor = true;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // btnCargarEmpleado
            // 
            this.btnCargarEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnCargarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCargarEmpleado.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnCargarEmpleado.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCargarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarEmpleado.IconSize = 32;
            this.btnCargarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarEmpleado.Location = new System.Drawing.Point(0, 235);
            this.btnCargarEmpleado.Name = "btnCargarEmpleado";
            this.btnCargarEmpleado.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCargarEmpleado.Size = new System.Drawing.Size(220, 60);
            this.btnCargarEmpleado.TabIndex = 2;
            this.btnCargarEmpleado.Text = "Cargar";
            this.btnCargarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarEmpleado.UseVisualStyleBackColor = true;
            this.btnCargarEmpleado.Click += new System.EventHandler(this.btnCargarEmpleado_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 235);
            this.panelLogo.TabIndex = 1;
            // 
            // lblCargarUsuario
            // 
            this.lblCargarUsuario.AutoSize = true;
            this.lblCargarUsuario.Location = new System.Drawing.Point(391, 185);
            this.lblCargarUsuario.Name = "lblCargarUsuario";
            this.lblCargarUsuario.Size = new System.Drawing.Size(185, 17);
            this.lblCargarUsuario.TabIndex = 2;
            this.lblCargarUsuario.Text = "CARGAR USUARIO NUEVO";
            this.lblCargarUsuario.Visible = false;
            // 
            // lblEditarUsuario
            // 
            this.lblEditarUsuario.AutoSize = true;
            this.lblEditarUsuario.Location = new System.Drawing.Point(391, 185);
            this.lblEditarUsuario.Name = "lblEditarUsuario";
            this.lblEditarUsuario.Size = new System.Drawing.Size(133, 17);
            this.lblEditarUsuario.TabIndex = 3;
            this.lblEditarUsuario.Text = "EDITAR USUARIOS";
            this.lblEditarUsuario.Visible = false;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnEditarEmpleado;
        private FontAwesome.Sharp.IconButton btnCargarEmpleado;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblEditarUsuario;
        private System.Windows.Forms.Label lblCargarUsuario;
    }
}