using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Core.Model;
using Core.Presenter;
using Core.View;

namespace FrutasVerduras.Pantallas
{
    public partial class Vision : UserControl,ICamara
    {

        private WCamara vistaCamara;

        private FilterInfoCollection Dispositivos; 
        private VideoCaptureDevice FuenteDeVideo; 


        public Bitmap img;

        public Vision()
        {
            InitializeComponent();
            vistaCamara = new WCamara(this);

        }

        private void Vision_Load(object sender, EventArgs e)
        { 
            //LISTAR DISPOSITIVOS DE ENTRADAS DE VIDEO
            vistaCamara.ListadoDispositivos();
        }
        #region ICamara
        public FilterInfoCollection videoDevices
        {
            get
            {
                return this.Dispositivos;
            }
            set
            {
                if (value != null)
                {
                    this.Dispositivos = value;
                    foreach (FilterInfo x in value)
                        devicesCombo.Items.Add(x.Name);
                    devicesCombo.SelectedIndex = 0;

            }
                else
                {
                    devicesCombo.Items.Add("No hay dispositivos");
                    devicesCombo.SelectedIndex = 0;
                }
            }
        }

        public VideoCaptureDevice videoDevice
        {
            get
            {
                return null;
            }

            set
            {
                
            }
        }

        public Bitmap imagenProceso
        {
            get
            {
                return null;
            }

            set
            {
                
            }
        }

        public void MensajeCamara(string Mensaje, int tipo)
        {
          
        }

        #endregion

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            //ESTABLECER EL DISPOSITIVO SELECCIONADO COMO FUENTE DE VIDEO
            FuenteDeVideo = new VideoCaptureDevice(Dispositivos[devicesCombo.SelectedIndex].MonikerString);
            //INICIALIZAR EL CONTROL
            FuenteDeVideo.NewFrame += new NewFrameEventHandler(c_NewFrame);
            //INICIAR LA RECEPCIÓN DE IMAGENES
            FuenteDeVideo.Start();
        }
        private void c_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bm = (Bitmap)eventArgs.Frame.Clone();
            pictureBoxCamara.Image = bm;
        }

        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            //DETENER LA RECEPCIÓN DE IMAGENES
            FuenteDeVideo.SignalToStop();
            FuenteDeVideo.WaitForStop();
            FuenteDeVideo.Stop();
        }

        private void buttonFoto_Click(object sender, EventArgs e)
        {
            //VARIBALE PARA LA IMAGEN
            img = new Bitmap(pictureBoxCamara.Image);
            //GUARDAR IMAGEN EN LA RUTA
            pictureBoxFotoGenerica.Image = img;


        }
    }
}
