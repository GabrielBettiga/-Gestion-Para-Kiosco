using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vistas
{
    public partial class FormPantallaInicial : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public FormPantallaInicial()
        {
            InitializeComponent();
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

        private void BTNproductos_Click(object sender, EventArgs e)
        {
            SubMenuProductos.Visible = true;
        }

        private void BtnCargarProducto_Click(object sender, EventArgs e)
        {
            SubMenuProductos.Visible = false;
        }
    }
}
