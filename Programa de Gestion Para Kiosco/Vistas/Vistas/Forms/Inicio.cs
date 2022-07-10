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



namespace Vistas
{
    public partial class BTNinicio : Form
    {
        //Campo
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form FormHijoActual;

        //Constructor
        public BTNinicio()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivateButton (object senderBtn, Color color)
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
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                IconoDeFormularioActual.IconChar = currentBtn.IconChar;
                IconoDeFormularioActual.IconColor = color;
                LBLtitulo.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn!= null)
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
            if(FormHijoActual != null)
            {
                //open only form
                FormHijoActual.Close();
            }
            FormHijoActual = FomHijo;
            FomHijo.TopLevel = false;
            FomHijo.FormBorderStyle = FormBorderStyle.None;
            FomHijo.Dock = DockStyle.Fill;
            PanelEscritorio.Controls.Add(FomHijo);
            PanelEscritorio.Tag = FomHijo;
            FomHijo.BringToFront();
            FomHijo.Show();
            LBLtitulo.Text = FomHijo.Text;
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

        //Menu Button_Clicks
        private void BRNproductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
           AbrirFormHijo(new Forms.Productos());
        }

        private void BTNcompras_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            AbrirFormHijo(new Forms.Compras());
        }

        private void BTNempleados_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            AbrirFormHijo(new Forms.Empleados());
        }

        private void BTNventas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AbrirFormHijo(new Forms.Ventas());
        }

        private void BTNreportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            AbrirFormHijo(new Forms.Reportes());
        }

        private void BTNconfiguracion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            AbrirFormHijo(new Forms.Configuracion());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormHijoActual.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            IconoDeFormularioActual.IconChar = IconChar.Home;
            IconoDeFormularioActual.IconColor = Color.MediumPurple;
            LBLtitulo.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BTNcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BTNmaximizar.Visible = false;
            BTNrestaurar.Visible = true;
        }

        private void BTNrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BTNrestaurar.Visible = false;
            BTNmaximizar.Visible = true;
        }

        private void BTNminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
