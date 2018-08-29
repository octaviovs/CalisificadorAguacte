using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Core.Model;
using Core.Presenter;
using Core.View;
using Core.Procesamiento;


namespace FrutasVerduras.Pantallas
{
    public partial class Vision : UserControl, ICamara, IDiccionario, IConexionSerial
    {

        private WCamara vistaCamara;

        private CDiccionario objDiccionario;
        private WDiccionario vistaDiccionario;

        private FilterInfoCollection Dispositivos;
        private VideoCaptureDevice FuenteDeVideo;


        public Bitmap img;

        public Histograma miHistograma;


        conexionSerial ArudinoConexion;
        WConexionSerial WconexionSerial;
        public bool bandera = true;

        //hilos
        ThreadStart delegadoArduino;
        ThreadStart delegadoCamara;
        Thread hiloArduino;
        Thread hiloCamara;

        delegate void CambiarProgresoDelegado(string texto, int valor);
        delegate void CambiarProgresoDelegadoFoto();

        public Vision()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;


            vistaCamara = new WCamara(this);

            vistaDiccionario = new WDiccionario(this);
            objDiccionario = new CDiccionario();

            miHistograma = new Histograma();


            ArudinoConexion = conexionSerial.Instance;
            WconexionSerial = new WConexionSerial(this);
            bandera = true;




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
            GuardarFotp();
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
        #endregion
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
            get
            {
                return null;
            }

            set
            {

            }
        }
        public void Mensaje(string Mensaje, int tipo)
        {




            if (Mensaje == "11")
            {
                // cuando me regrese un 11 arduino dice que si hay algo enfrente 
                //entonces tenemos que procesar la imgen en un tiempo de 5 segundos
                //para esto se relaiza el proceso de 
                //    proceso();
                // labelDistancia.Text = "11";

            }
            if (Mensaje == "00")
            {
                //  labelDistancia.Text = "00";

                //en caso que retorne un 00 significa que NO HAY un objeto enfren el arduino avanca 10 cm
                //se vulve a repetir el proceso hasta que sea 11
                //    bandaProceso();
            }



        }


        #endregion



        private void buttonProceso_Click(object sender, EventArgs e)
        {
            delegadoArduino = new ThreadStart(bandaProceso);
            delegadoCamara = new ThreadStart(CamaraProceso);
            //Creamos la instancia del hilo 
            hiloArduino = new Thread(delegadoArduino);
            hiloCamara = new Thread(delegadoCamara);
            try
            {
                //Iniciamos el hilo 
                hiloArduino.Start();
                hiloCamara.Start();
            }
            catch (Exception)
            {
                hiloArduino.Abort();
                hiloCamara.Abort();
            }

        }
        /// <summary>
        /// Medotodo que hace avanzar la bamda
        /// </summary>
        private void bandaProceso()
        {

            //Algoritmo
            /*
             * version actual
             * activamos la banda
             * 
                este metodo envia una señal al arduino en dodne le dice
                si hay un objeto enfrente de la camara, el resultado se ve
                reflejado en la vista Mensaje
                version nuvea
           
             */

            while (bandera)
            {
                Thread.Sleep(3000);
                WconexionSerial.setDato("a");
                Thread.Sleep(3200);
            }

        }
        /// <summary>
        /// Metodo que realiza la captira de imagen
        /// </summary>
        private void CamaraProceso()
        {
            while (bandera)
            {
                Thread.Sleep(3000);
                proceso();
            }
        }
        /// <summary>
        /// Metodo que se encarga de procesar la imagen
        /// </summary>
        private void proceso()
        {
            img = null;

            try
            {
                img = new Bitmap(pictureBoxCamara.Image);
            }
            catch (Exception)
            {

                if (pictureBoxCamara.InvokeRequired)
                {
                    CambiarProgresoDelegadoFoto delegadoArduino = new CambiarProgresoDelegadoFoto(proceso);
                    this.Invoke(delegadoArduino, null);
                }
                else
                {
                    img = new Bitmap(pictureBoxCamara.Image);

                }
            }





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


            CDiccionario valuesR = new CDiccionario();
            valuesR.valueAr = vR[0];
            valuesR.valueBr = vR[1];
            valuesR.valueCr = vR[2];
            valuesR.valueDr = vR[3];

            valuesR.valueAv = vV[0];
            valuesR.valueBv = vV[1];
            valuesR.valueCv = vV[2];
            valuesR.valueDv = vV[3];

            valuesR.valueAa = vA[0];
            valuesR.valueBa = vA[1];
            valuesR.valueCa = vA[2];
            valuesR.valueDa = vA[3];

            vistaDiccionario.EsMaduro(6, valuesR);
        }

        private void GuardarFotp()
        {
            img = null;

            try
            {
                img = new Bitmap(pictureBoxCamara.Image);
            }
            catch (Exception)
            {

                img = new Bitmap(pictureBoxCamara.Image);
            }





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


            CDiccionario valuesR = new CDiccionario();
            valuesR.valueAr = vR[0];
            valuesR.valueBr = vR[1];
            valuesR.valueCr = vR[2];
            valuesR.valueDr = vR[3];

            valuesR.valueAv = vV[0];
            valuesR.valueBv = vV[1];
            valuesR.valueCv = vV[2];
            valuesR.valueDv = vV[3];

            valuesR.valueAa = vA[0];
            valuesR.valueBa = vA[1];
            valuesR.valueCa = vA[2];
            valuesR.valueDa = vA[3];
            valuesR.tipo = 1;

          vistaDiccionario.Reguistrar(1, valuesR);
        }
        public void MensajeDiccionario(string Mensaje, int tipo)
        {
            textBox1.Text = "";

            string res = "";

            switch (tipo)
            {
                case 6:
                    if (this.InvokeRequired)
                    {
                        CambiarProgresoDelegado delegado = new CambiarProgresoDelegado(MensajeDiccionario);
                        try
                        {



                            object[] parametros = new object[] { Mensaje, tipo };
                            //invocamos el método a través del mismo contexto del formulario (this) y enviamos los parámetros 
                            this.Invoke(delegado, parametros);

                        }
                        catch (Exception)
                        {

                            delegado = null;

                            delegado = new CambiarProgresoDelegado(MensajeDiccionario);
                            object[] parametros = new object[] { Mensaje, tipo };
                            //invocamos el método a través del mismo contexto del formulario (this) y enviamos los parámetros 
                            this.Invoke(delegado, parametros);
                        }

                    }
                    else
                    {
                        string[] values = Mensaje.Split('|');
                        //                    textBox1.Text = Mensaje;
                        // si a es mayor a b es maduro
                        if (Convert.ToInt32(values[0]) > Convert.ToInt32(values[1]))
                        {
                            res = "a";
                        }
                        else
                        {
                            res = "b";
                        }

                        if (res == "a")
                        {

                            labelResultado.Text = "MADURO";
                            WconexionSerial.setDato("k");
                        }
                        if (res == "b")
                        {

                            labelResultado.Text = "VERDE";
                            
                       
                        }
                    }
                    break;
                default:
                    break;
            }
        }



    }
}
