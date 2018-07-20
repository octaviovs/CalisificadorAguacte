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
using Core.Procesamiento;
namespace FrutasVerduras.Pantallas
{
    public partial class Vision : UserControl,ICamara
    {

        private WCamara vistaCamara;

        private FilterInfoCollection Dispositivos; 
        private VideoCaptureDevice FuenteDeVideo; 


        public Bitmap img;

        Histograma miHistograma;
        
        public Vision()
        {
            InitializeComponent();
            vistaCamara = new WCamara(this);
            miHistograma = new Histograma();

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
            pictureBoxFotoGenerica.Image = CropBitmap(img,300,300,100,100);


            Bitmap lol = new Bitmap(pictureBoxFotoGenerica.Image);


            int[,] values = miHistograma.getHistograma(lol);
                        int[] rojo = new int[values.GetLength(1)];
                        int[] verde = new int[values.GetLength(1)];
                        int[] azul = new int[values.GetLength(1)];
                        for (int i = 0; i < values.GetLength(0); i++)
                        {

                            for (int j = 0; j < values.GetLength(1); j++)
                            {
                                rojo[j] =(i==0) ? values[i, j]: rojo[j];
                                verde[j] = (i == 1) ? values[i, j] : rojo[j];
                                azul[j] = (i == 2) ? values[i, j] : rojo[j];
                            }

                        }

                    histogramRojo.UseWaitCursor = true;
                       histogramRojo.Values = rojo;
                        histogramVerde.Values = verde;
                        histogramAzul.Values = azul;
        }

        public Bitmap CropBitmap(Bitmap bitmap, int cropX, int cropY, int cropWidth, int cropHeight)
        {
            Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
            Bitmap cropped = bitmap.Clone(rect, bitmap.PixelFormat);
            return cropped;
        }
    }
}
