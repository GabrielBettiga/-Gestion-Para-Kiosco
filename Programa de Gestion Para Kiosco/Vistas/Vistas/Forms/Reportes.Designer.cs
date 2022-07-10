
namespace Vistas.Forms
{
    partial class Reportes
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
            this.lblHistorialDeCierre = new System.Windows.Forms.Label();
            this.lblCierreDeCaja = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHistorialDeCierre = new FontAwesome.Sharp.IconButton();
            this.btnCierreDeCaja = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.lblHistorialDeCierre);
            this.panel1.Controls.Add(this.lblCierreDeCaja);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 504);
            this.panel1.TabIndex = 6;
            // 
            // lblHistorialDeCierre
            // 
            this.lblHistorialDeCierre.AutoSize = true;
            this.lblHistorialDeCierre.Location = new System.Drawing.Point(427, 132);
            this.lblHistorialDeCierre.Name = "lblHistorialDeCierre";
            this.lblHistorialDeCierre.Size = new System.Drawing.Size(157, 17);
            this.lblHistorialDeCierre.TabIndex = 3;
            this.lblHistorialDeCierre.Text = "HISTORIAL DE CIERRE";
            this.lblHistorialDeCierre.Visible = false;
            // 
            // lblCierreDeCaja
            // 
            this.lblCierreDeCaja.AutoSize = true;
            this.lblCierreDeCaja.Location = new System.Drawing.Point(427, 132);
            this.lblCierreDeCaja.Name = "lblCierreDeCaja";
            this.lblCierreDeCaja.Size = new System.Drawing.Size(119, 17);
            this.lblCierreDeCaja.TabIndex = 2;
            this.lblCierreDeCaja.Text = "CIERRE DE CAJA";
            this.lblCierreDeCaja.Visible = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnHistorialDeCierre);
            this.panelMenu.Controls.Add(this.btnCierreDeCaja);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 504);
            this.panelMenu.TabIndex = 1;
            // 
            // btnHistorialDeCierre
            // 
            this.btnHistorialDeCierre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialDeCierre.FlatAppearance.BorderSize = 0;
            this.btnHistorialDeCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialDeCierre.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHistorialDeCierre.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnHistorialDeCierre.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHistorialDeCierre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorialDeCierre.IconSize = 32;
            this.btnHistorialDeCierre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialDeCierre.Location = new System.Drawing.Point(0, 415);
            this.btnHistorialDeCierre.Name = "btnHistorialDeCierre";
            this.btnHistorialDeCierre.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHistorialDeCierre.Size = new System.Drawing.Size(220, 60);
            this.btnHistorialDeCierre.TabIndex = 3;
            this.btnHistorialDeCierre.Text = "Historial de Cierres";
            this.btnHistorialDeCierre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialDeCierre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorialDeCierre.UseVisualStyleBackColor = true;
            this.btnHistorialDeCierre.Click += new System.EventHandler(this.btnHistorialDeCierre_Click);
            // 
            // btnCierreDeCaja
            // 
            this.btnCierreDeCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCierreDeCaja.FlatAppearance.BorderSize = 0;
            this.btnCierreDeCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierreDeCaja.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCierreDeCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnCierreDeCaja.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCierreDeCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCierreDeCaja.IconSize = 32;
            this.btnCierreDeCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCierreDeCaja.Location = new System.Drawing.Point(0, 355);
            this.btnCierreDeCaja.Name = "btnCierreDeCaja";
            this.btnCierreDeCaja.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCierreDeCaja.Size = new System.Drawing.Size(220, 60);
            this.btnCierreDeCaja.TabIndex = 2;
            this.btnCierreDeCaja.Text = "Cierre De Caja";
            this.btnCierreDeCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCierreDeCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCierreDeCaja.UseVisualStyleBackColor = true;
            this.btnCierreDeCaja.Click += new System.EventHandler(this.btnCierreDeCaja_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 355);
            this.panelLogo.TabIndex = 1;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.panel1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHistorialDeCierre;
        private System.Windows.Forms.Label lblCierreDeCaja;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHistorialDeCierre;
        private FontAwesome.Sharp.IconButton btnCierreDeCaja;
        private System.Windows.Forms.Panel panelLogo;
    }
}