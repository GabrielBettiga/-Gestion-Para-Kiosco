
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BTN_ANTERIOR = new System.Windows.Forms.Button();
            this.BTN_SIGUIENTE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 462);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTN_SIGUIENTE);
            this.panel2.Controls.Add(this.BTN_ANTERIOR);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 462);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(96, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(742, 271);
            this.dataGridView2.TabIndex = 2;
            // 
            // BTN_ANTERIOR
            // 
            this.BTN_ANTERIOR.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_ANTERIOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ANTERIOR.FlatAppearance.BorderSize = 0;
            this.BTN_ANTERIOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ANTERIOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ANTERIOR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_ANTERIOR.Location = new System.Drawing.Point(309, 359);
            this.BTN_ANTERIOR.Name = "BTN_ANTERIOR";
            this.BTN_ANTERIOR.Size = new System.Drawing.Size(103, 42);
            this.BTN_ANTERIOR.TabIndex = 3;
            this.BTN_ANTERIOR.Text = "ANTERIOR";
            this.BTN_ANTERIOR.UseVisualStyleBackColor = false;
            this.BTN_ANTERIOR.Click += new System.EventHandler(this.BTN_ANTERIOR_Click);
            // 
            // BTN_SIGUIENTE
            // 
            this.BTN_SIGUIENTE.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_SIGUIENTE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SIGUIENTE.FlatAppearance.BorderSize = 0;
            this.BTN_SIGUIENTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SIGUIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SIGUIENTE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_SIGUIENTE.Location = new System.Drawing.Point(534, 359);
            this.BTN_SIGUIENTE.Name = "BTN_SIGUIENTE";
            this.BTN_SIGUIENTE.Size = new System.Drawing.Size(103, 42);
            this.BTN_SIGUIENTE.TabIndex = 4;
            this.BTN_SIGUIENTE.Text = "SIGUIENTE";
            this.BTN_SIGUIENTE.UseVisualStyleBackColor = false;
            this.BTN_SIGUIENTE.Click += new System.EventHandler(this.BTN_SIGUIENTE_Click);
            // 
            // EditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 462);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditarProductos";
            this.Text = "EditarProductos";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BTN_SIGUIENTE;
        private System.Windows.Forms.Button BTN_ANTERIOR;
    }
}