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

        private void button1_Click(object sender, EventArgs e)
        {
            //ESTABLECER EL DISPOSITIVO SELECCIONADO COMO FUENTE DE VIDEO
            FuenteDeVideo = new VideoCaptureDevice(Dispositivos[devicesCombo.SelectedIndex].MonikerString);
            //INICIALIZAR EL CONTROL
            videoSourcePlayer1.VideoSource = FuenteDeVideo;
            //INICIAR LA RECEPCIÓN DE IMAGENES
            videoSourcePlayer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //DETENER LA RECEPCIÓN DE IMAGENES
            //DETENER LA RECEPCIÓN DE IMAGENES
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer1.VideoSource = null;
          

        }

   

        private void button3_Click(object sender, EventArgs e)
        {


            //VARIBALE PARA LA IMAGEN
            img = videoSourcePlayer1.GetCurrentVideoFrame();
            //GUARDAR IMAGEN EN LA RUTA

            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = img.Clone(
                new Rectangle(0, 0, img.Width, img.Height),
                System.Drawing.Imaging.PixelFormat.DontCare);
            //BORRAR IMAGEN DE MEMORIA
            img.Dispose();

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

      
    }
}
