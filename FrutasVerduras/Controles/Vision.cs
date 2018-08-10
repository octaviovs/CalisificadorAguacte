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
    public partial class Vision : UserControl, ICamara,IDiccionario
    {

        private WCamara vistaCamara;

        private CDiccionario objDiccionario;
        private WDiccionario vistaDiccionario;

        private FilterInfoCollection Dispositivos;
        private VideoCaptureDevice FuenteDeVideo;


        public Bitmap img;

        public Histograma miHistograma;

        public Vision()
        {
            InitializeComponent();


            vistaCamara = new WCamara(this);

            vistaDiccionario = new WDiccionario(this);
            objDiccionario = new CDiccionario();

            miHistograma = new Histograma();

        }

        private void Vision_Load(object sender, EventArgs e)
        {
            //LISTAR DISPOSITIVOS DE ENTRADAS DE VIDEO
            vistaCamara.ListadoDispositivos();
        }
      

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
            //VARIBALE PARA LA IMAGEN- imagen original
            img = new Bitmap(pictureBoxCamara.Image);
            //GUARDAR IMAGEN EN LA RUTA- se recorta la imagen orginar
            pictureBoxFotoGenerica.Image = CropBitmap(img, 500, 500, 220, 220);
            Bitmap fotoProcesada = new Bitmap(pictureBoxFotoGenerica.Image);

            int[,] values = miHistograma.getHistograma(fotoProcesada);
            int[] rojo = new int[values.GetLength(1)];
            int[] verde = new int[values.GetLength(1)];
            int[] azul = new int[values.GetLength(1)];
            int[] generico = new int[values.GetLength(1)];

            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    rojo[j] = (i == 0) ? values[i, j] : rojo[j];
                    verde[j] = (i == 1) ? values[i, j] : verde[j];
                    azul[j] = (i == 2) ? values[i, j] : azul[j];
                }
            }

            histogramRojo.Values = rojo;
            histogramVerde.Values = verde;
            histogramAzul.Values = azul;
           
            int[] vR = miHistograma.GetPorcentajesColor(rojo);
            int[] vV = miHistograma.GetPorcentajesColor(verde);
            int[] vA = miHistograma.GetPorcentajesColor(azul);

            objDiccionario.datoA = vR[0];
            objDiccionario.datoB = vR[1];
            objDiccionario.datoC = vR[2];
            objDiccionario.datoD = vR[3];

           // vistaDiccionario.Reguistrar(1,objDiccionario);
            objDiccionario.datoA = vV[0];
            objDiccionario.datoB = vV[1];
            objDiccionario.datoC = vV[2];
            objDiccionario.datoD = vV[3];

          //  vistaDiccionario.Reguistrar(2, objDiccionario);
            objDiccionario.datoA = vA[0];
            objDiccionario.datoB = vA[1];
            objDiccionario.datoC = vA[2];
            objDiccionario.datoD = vA[3];

         //   vistaDiccionario.Reguistrar(3, objDiccionario);

        }

        public Bitmap CropBitmap(Bitmap bitmap, int cropX, int cropY, int cropWidth, int cropHeight)
        {
            Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
            Bitmap cropped = bitmap.Clone(rect, bitmap.PixelFormat);
            return cropped;
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



        #endregion
        #region IDiccionario
        public CDiccionario DiccionarioObj
        {
            get
            {
                return null;
            }

            set
            {

            }
        }

        public DataSet DatosDT
        {
            set
            {

            }
        }

        public void MensajeCamara(string Mensaje, int tipo)
        {

        }
        public void MensajeDiccionario(string Mensaje, int tipo)
        {
           
        }
        #endregion
    }
}
