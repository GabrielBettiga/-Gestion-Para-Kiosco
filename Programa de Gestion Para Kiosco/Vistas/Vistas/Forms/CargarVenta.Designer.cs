
namespace Vistas.Forms
{
    partial class CargarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarVenta));
            this.SUBpanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numericUpDown_CANTIDAD_PRODUCTO = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TXT_CODIGO_PRODUCTO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GridView_productosXcomprar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.SUBpanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CANTIDAD_PRODUCTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_productosXcomprar)).BeginInit();
            this.SuspendLayout();
            // 
            // SUBpanel
            // 
            this.SUBpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.SUBpanel.Controls.Add(this.flowLayoutPanel1);
            this.SUBpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SUBpanel.Location = new System.Drawing.Point(0, 0);
            this.SUBpanel.Name = "SUBpanel";
            this.SUBpanel.Size = new System.Drawing.Size(1159, 572);
            this.SUBpanel.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1159, 572);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.GridView_productosXcomprar);
            this.panel6.Controls.Add(this.numericUpDown_CANTIDAD_PRODUCTO);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.iconPictureBox1);
            this.panel6.Controls.Add(this.TXT_CODIGO_PRODUCTO);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1159, 365);
            this.panel6.TabIndex = 4;
            // 
            // numericUpDown_CANTIDAD_PRODUCTO
            // 
            this.numericUpDown_CANTIDAD_PRODUCTO.Location = new System.Drawing.Point(725, 62);
            this.numericUpDown_CANTIDAD_PRODUCTO.Name = "numericUpDown_CANTIDAD_PRODUCTO";
            this.numericUpDown_CANTIDAD_PRODUCTO.Size = new System.Drawing.Size(61, 22);
            this.numericUpDown_CANTIDAD_PRODUCTO.TabIndex = 5;
            this.numericUpDown_CANTIDAD_PRODUCTO.Enter += new System.EventHandler(this.numericUpDown_CANTIDAD_PRODUCTO_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(722, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.BackgroundImage")));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 208;
            this.iconPictureBox1.Location = new System.Drawing.Point(26, 23);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(208, 317);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // TXT_CODIGO_PRODUCTO
            // 
            this.TXT_CODIGO_PRODUCTO.Location = new System.Drawing.Point(275, 61);
            this.TXT_CODIGO_PRODUCTO.Name = "TXT_CODIGO_PRODUCTO";
            this.TXT_CODIGO_PRODUCTO.Size = new System.Drawing.Size(391, 22);
            this.TXT_CODIGO_PRODUCTO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(272, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de producto";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox10);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.textBox8);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.iconButton2);
            this.panel7.Controls.Add(this.textBox9);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.textBox7);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 374);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1159, 237);
            this.panel7.TabIndex = 5;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(93, 152);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(184, 22);
            this.textBox10.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(4, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cambio :";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(93, 113);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(184, 22);
            this.textBox8.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(4, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Pago Con :";
            // 
            // iconButton2
            // 
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Lime;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(7, 195);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(270, 39);
            this.iconButton2.TabIndex = 13;
            this.iconButton2.Text = "Terminar Venta";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(93, 50);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(184, 22);
            this.textBox9.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(4, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "TOTAL :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(93, 22);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(184, 22);
            this.textBox7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(3, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "SubTotal :";
            // 
            // GridView_productosXcomprar
            // 
            this.GridView_productosXcomprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_productosXcomprar.Location = new System.Drawing.Point(306, 115);
            this.GridView_productosXcomprar.Name = "GridView_productosXcomprar";
            this.GridView_productosXcomprar.RowHeadersWidth = 51;
            this.GridView_productosXcomprar.RowTemplate.Height = 24;
            this.GridView_productosXcomprar.Size = new System.Drawing.Size(680, 198);
            this.GridView_productosXcomprar.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(826, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numericUpDown_CANTIDAD_PRODUCTO_Enter);
            // 
            // CargarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1159, 572);
            this.Controls.Add(this.SUBpanel);
            this.Name = "CargarVenta";
            this.Text = "CargarVenta";
            this.SUBpanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CANTIDAD_PRODUCTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_productosXcomprar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SUBpanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox TXT_CODIGO_PRODUCTO;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_CANTIDAD_PRODUCTO;
        private System.Windows.Forms.DataGridView GridView_productosXcomprar;
        private System.Windows.Forms.Button button1;
    }
}