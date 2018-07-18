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
using System.IO.Ports;

namespace FrutasVerduras.Pantallas
{
    public partial class Conexion : Form,IConexionSerial
    {
        conexionSerial ArudinoConexion;
        WConexionSerial WconexionSerial;
        public Conexion()
        {
            InitializeComponent();

            WconexionSerial = new WConexionSerial(this);
            WconexionSerial.ListadoPuertos();
            ArudinoConexion= conexionSerial.Instance; 

        }

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
            get
            {
                return null;
            }

            set
            {
                comboBoxPuertos.Items.Clear();
                if (value!=null)
                {
                    
                    foreach (var item in value)
                    {
                        comboBoxPuertos.Items.Add(item);
                    }
                }
            }
        }

        public void Mensaje(string Mensaje, int tipo)
        {
            switch (tipo)
            {
                case 1: labelMensaje.Text = Mensaje; break;
                case 2: labelMensaje.Text = Mensaje; break;
                case 3: labelMensaje.Text = Mensaje; break;
                case 4: labelMensaje.Text = Mensaje; break;
                default:
                    labelMensaje.Text = Mensaje;
                    break;
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            WconexionSerial.ListadoPuertos();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {

            try
            {
                string valor = comboBoxPuertos.Text;
                if (valor != "" )
                {

                    ArudinoConexion.miPuerto.Close();
                    ArudinoConexion.Puerto = comboBoxPuertos.SelectedItem.ToString();
                    //propiedades del objeto
                    ArudinoConexion.miPuerto.PortName = valor;
                    ArudinoConexion.miPuerto.BaudRate = 9600;
                    if (!ArudinoConexion.miPuerto.IsOpen) {
                        ArudinoConexion.miPuerto.Open();
                    }
               

                }
                else
                {
                    MessageBox.Show("No hay algun puerto :v");
                }
            }
            catch (Exception mensa )
            {

                Mensaje(mensa.ToString(), 2);
            }
           
         }

      
    }
}
