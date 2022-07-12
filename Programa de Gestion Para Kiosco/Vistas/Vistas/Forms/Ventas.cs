using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Vistas.Forms
{
    public partial class Ventas : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form FormHijoActual;
        public Ventas()
        {
            InitializeComponent();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left Border Button
                /*
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();*/
                //Icon Current Child Form
                /*
                IconoDeFormularioActual.IconChar = currentBtn.IconChar;
                IconoDeFormularioActual.IconColor = color;
                LBLtitulo.Text = currentBtn.Text;
                */
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {

                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void AbrirFormHijo(Form FomHijo)
        {
            if (FormHijoActual != null)
            {
                //open only form
                FormHijoActual.Close();
            }
            FormHijoActual = FomHijo;
            FomHijo.TopLevel = false;
            FomHijo.FormBorderStyle = FormBorderStyle.None;
            FomHijo.Dock = DockStyle.Fill;
            SUBpanel.Controls.Add(FomHijo);
            SUBpanel.Tag = FomHijo;
            FomHijo.BringToFront();
            FomHijo.Show();


        }

        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AbrirFormHijo(new Forms.CargarVenta());

        }

        private void btnHistorialDeVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AbrirFormHijo(new Forms.HistorialDeVentas());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
