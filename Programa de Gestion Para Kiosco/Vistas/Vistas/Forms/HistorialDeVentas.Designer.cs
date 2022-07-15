
namespace Vistas.Forms
{
    partial class HistorialDeVentas
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
            this.SUBpanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BTN_SIGUIENTE = new System.Windows.Forms.Button();
            this.BTN_ANTERIOR = new System.Windows.Forms.Button();
            this.SUBpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // SUBpanel
            // 
            this.SUBpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.SUBpanel.Controls.Add(this.BTN_SIGUIENTE);
            this.SUBpanel.Controls.Add(this.BTN_ANTERIOR);
            this.SUBpanel.Controls.Add(this.dataGridView2);
            this.SUBpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SUBpanel.Location = new System.Drawing.Point(0, 0);
            this.SUBpanel.Name = "SUBpanel";
            this.SUBpanel.Size = new System.Drawing.Size(1171, 661);
            this.SUBpanel.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridView2.Location = new System.Drawing.Point(165, 143);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(821, 329);
            this.dataGridView2.TabIndex = 3;
            // 
            // BTN_SIGUIENTE
            // 
            this.BTN_SIGUIENTE.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_SIGUIENTE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SIGUIENTE.FlatAppearance.BorderSize = 0;
            this.BTN_SIGUIENTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SIGUIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SIGUIENTE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_SIGUIENTE.Location = new System.Drawing.Point(675, 558);
            this.BTN_SIGUIENTE.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_SIGUIENTE.Name = "BTN_SIGUIENTE";
            this.BTN_SIGUIENTE.Size = new System.Drawing.Size(137, 52);
            this.BTN_SIGUIENTE.TabIndex = 6;
            this.BTN_SIGUIENTE.Text = "SIGUIENTE";
            this.BTN_SIGUIENTE.UseVisualStyleBackColor = false;
            this.BTN_SIGUIENTE.Click += new System.EventHandler(this.BTN_SIGUIENTE_Click);
            // 
            // BTN_ANTERIOR
            // 
            this.BTN_ANTERIOR.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_ANTERIOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ANTERIOR.FlatAppearance.BorderSize = 0;
            this.BTN_ANTERIOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ANTERIOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ANTERIOR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_ANTERIOR.Location = new System.Drawing.Point(353, 558);
            this.BTN_ANTERIOR.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_ANTERIOR.Name = "BTN_ANTERIOR";
            this.BTN_ANTERIOR.Size = new System.Drawing.Size(137, 52);
            this.BTN_ANTERIOR.TabIndex = 5;
            this.BTN_ANTERIOR.Text = "ANTERIOR";
            this.BTN_ANTERIOR.UseVisualStyleBackColor = false;
            this.BTN_ANTERIOR.Click += new System.EventHandler(this.BTN_ANTERIOR_Click);
            // 
            // HistorialDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 661);
            this.Controls.Add(this.SUBpanel);
            this.Name = "HistorialDeVentas";
            this.Text = "HistorialDeVentas";
            this.SUBpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SUBpanel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BTN_SIGUIENTE;
        private System.Windows.Forms.Button BTN_ANTERIOR;
    }
}