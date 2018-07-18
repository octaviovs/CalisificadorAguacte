using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using System.Runtime.InteropServices;
namespace FrutasVerduras.Pantallas
{
    public partial class contenedor : Form
    {

        public contenedor()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




        #region iconos
        private void inconCerrar_Click(object sender, EventArgs e)
        {

           
            Application.Exit();

        }
        private void inconMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconRestau.Visible = true;
            inconMaxi.Visible = false;
        }

        private void IconRestau_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconRestau.Visible = !true;
            inconMaxi.Visible = !false;
        }

        private void Iconmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Botones
        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 210)
            {
                MenuVertical.Width = 70;
                vision1.Width = 1000;
            }
            else
            {
                MenuVertical.Width = 210;
                vision1.Width = 960;
            }
        }
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void buttonMaquina_Click(object sender, EventArgs e)
        {
          
        }
        private void buttonConfCamara_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfPuertos_Click(object sender, EventArgs e)
        {
            AbririFormPanel(new Conexion());
        }
        private void buttonDocumentacion_Click(object sender, EventArgs e)
        {

        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        #endregion
        private void AbririFormPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }








    }
}
