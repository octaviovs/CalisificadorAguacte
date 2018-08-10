using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Model;
using Core.Presenter;
using Core.View;
using Core.Procesamiento;

namespace FrutasVerduras.Pantallas
{
    public partial class banda : Form,IConexionSerial
    {
        WConexionSerial vistaConexionSerial;
        public banda()
        {
            InitializeComponent();
            vistaConexionSerial = new WConexionSerial(this);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        #region IconexionSerial
        public conexionSerial objConexion
        {
            get
            {
                return null;
            }

            set
            {
              
            }
        }

        public List<string> puertos
        {
            set
            {
                
            }
        }

        public void Mensaje(string Mensaje, int tipo)
        {
            labelMensaje.Text = "";
            labelMensaje.Text= Mensaje;
        }

        #endregion

        private void buttonOn_Click(object sender, EventArgs e)
        {
            vistaConexionSerial.prednerLed("x");
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            vistaConexionSerial.prednerLed("y");
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            vistaConexionSerial.setDato("e");
            vistaConexionSerial.getDato();
        }
    }
}
