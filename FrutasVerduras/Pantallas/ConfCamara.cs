// Snapshot Maker sample application
// AForge.NET Framework
// http://www.aforgenet.com/framework/
//


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class ConfCamara : Form, ICamara
    {
        CCamara CamaraObjeto;
        WCamara WCamara;
      
        public ConfCamara()
        {
            InitializeComponent();
            CamaraObjeto = new CCamara();
            WCamara = new WCamara(this);
         //   Disconnect();

        }
        private void ConfCamara_Load(object sender, EventArgs e)
        {
           
            WCamara.ListadoDispositivos();//Listado de dispositivos
            EnableConnectionControls(true);//Activa los controles

        }
        #region ICamara
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
        VideoCapabilities[] AuxsnapshotCapabilities;
        public VideoCapabilities[] snapshotCapabilities
        {
            get
            {
                return AuxsnapshotCapabilities;
            }

            set
            {
                if (value != null)
                {
                    AuxsnapshotCapabilities = value;
                }
            }
        }

        VideoCapabilities[] AuxvideoCapabilities;
        public VideoCapabilities[] videoCapabilities
        {
            get
            {

                return AuxvideoCapabilities;

            }

            set
            {
                if (value != null)
                {

                    AuxvideoCapabilities = value;
                }
            }
        }
        VideoCaptureDevice AuxvideoDevice;
        public VideoCaptureDevice videoDevice
        {
            get
            {
                return AuxvideoDevice;
            }

            set
            {
                if (value != null)
                {
                    AuxvideoDevice = value;
                }
            }
        }

        private FilterInfoCollection videoDevicesAux;
        public FilterInfoCollection videoDevices
        {
            get
            {
                return videoDevicesAux;

            }
            set
            {
                if (value != null)
                {
                    foreach (FilterInfo device in value)
                        devicesCombo.Items.Add(device.Name);
                    videoDevicesAux = value;
                }
                else
                {
                    devicesCombo.Items.Add("No hay dispositivos");
                    devicesCombo.SelectedIndex = 0;
                }
            }
        }

        public void MensajeCamara(string Mensaje, int tipo)
        {
            switch (tipo)
            {
                default:
                    break;
            }
        }

        #endregion

        #region metodos Genericos
        //Metodo de activa o desactiva los controles
        private void EnableConnectionControls(bool enable)
        {
            devicesCombo.Enabled = enable;
            videoResolutionsCombo.Enabled = enable;
            snapshotResolutionsCombo.Enabled = enable;
            connectButton.Enabled = enable;
            disconnectButton.Enabled = !enable;
            triggerButton.Enabled = (!enable) && (snapshotCapabilities.Length != 0);
        }
        // Collect supported video and snapshot sizes
        private void EnumeratedSupportedFrameSizes(VideoCaptureDevice videoDevice)
        {
            this.Cursor = Cursors.WaitCursor;

            videoResolutionsCombo.Items.Clear();
            snapshotResolutionsCombo.Items.Clear();

            try
            {

          



                foreach (VideoCapabilities capabilty in videoCapabilities)
                {
                    videoResolutionsCombo.Items.Add(string.Format("{0} x {1}",
                        capabilty.FrameSize.Width, capabilty.FrameSize.Height));
                }

                foreach (VideoCapabilities capabilty in snapshotCapabilities)
                {
                    snapshotResolutionsCombo.Items.Add(string.Format("{0} x {1}",
                        capabilty.FrameSize.Width, capabilty.FrameSize.Height));
                }

                if (videoCapabilities.Length == 0)
                {
                    videoResolutionsCombo.Items.Add("Not supported");
                }
                if (snapshotCapabilities.Length == 0)
                {
                    snapshotResolutionsCombo.Items.Add("Not supported");
                }

                videoResolutionsCombo.SelectedIndex = 0;
                snapshotResolutionsCombo.SelectedIndex = 0;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Disconnect()
        {
            if (videoSourcePlayer.VideoSource != null)
            {
                // stop video device
                videoSourcePlayer.SignalToStop();
                videoSourcePlayer.WaitForStop();
                videoSourcePlayer.VideoSource = null;

                if (videoDevice.ProvideSnapshots)
                {
                    //  private void Disconnect( )
                    {
                        if (videoSourcePlayer.VideoSource != null)
                        {
                            // stop video device
                            videoSourcePlayer.SignalToStop();
                            videoSourcePlayer.WaitForStop();
                            videoSourcePlayer.VideoSource = null;

                            if (videoDevice.ProvideSnapshots)
                            {
                               // videoDevice.SnapshotFrame -= new NewFrameEventHandler(videoDevice_SnapshotFrame);
                            }

                            EnableConnectionControls(true);
                        }
                    }
                  //  videoDevice.SnapshotFrame -= new NewFrameEventHandler(videoDevice_SnapshotFrame);
                }

                EnableConnectionControls(true);
            }
        }
        #endregion

        //Eventos

        private void ConfCamara_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
        }
        private void ConfCamara_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }
        private void devicesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoDevices.Count != 0)
            {
               
                EnumeratedSupportedFrameSizes(videoDevice);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)
            {
                if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                {
                    videoDevice.VideoResolution = videoCapabilities[videoResolutionsCombo.SelectedIndex];
                }

                if ((snapshotCapabilities != null) && (snapshotCapabilities.Length != 0))
                {
                    videoDevice.ProvideSnapshots = true;
                    videoDevice.SnapshotResolution = snapshotCapabilities[snapshotResolutionsCombo.SelectedIndex];


                    videoDevice.SnapshotFrame += new NewFrameEventHandler(videoDevice_SnapshotFrame); //////Verificar esta parte
                }

                EnableConnectionControls(false);

                videoSourcePlayer.VideoSource = videoDevice;
                videoSourcePlayer.Start();
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void triggerButton_Click(object sender, EventArgs e)
        {

            if ((videoDevice != null) && (videoDevice.ProvideSnapshots))
            {
                videoDevice.SimulateTrigger();
            }


        }
        private void videoDevice_SnapshotFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Console.WriteLine(eventArgs.Frame.Size);

            ShowSnapshot((Bitmap)eventArgs.Frame.Clone());
        }

        private void ShowSnapshot(Bitmap snapshot)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Bitmap>(ShowSnapshot), snapshot);
            }
            else
            {
                //if (snapshotForm == null)
                //{
                //    snapshotForm = new Procesamiento();
                //    snapshotForm.FormClosed += new FormClosedEventHandler(snapshotForm_FormClosed);
                //    snapshotForm.Show();
                //}

                //  snapshotForm.SetImage(snapshot);
            }
        }

        private void snapshotForm_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  snapshotForm = null;
        }


    }
}
