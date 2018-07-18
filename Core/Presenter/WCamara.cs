using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Model;
using Core.View;

using AForge.Video;
using AForge.Video.DirectShow;



namespace Core.Presenter
{
    public class WCamara
    {
        ICamara ViewCamara;
        CCamara objCamara;
        public WCamara(ICamara InterfazCamara) {
            
            ViewCamara = InterfazCamara;
            objCamara = new CCamara();
        }
        public bool ExisteConexion()
        {
            bool ConexcionAvierta = false;
            if (true)
            {

            }
           
            return ConexcionAvierta;
        }
        public void ListadoDispositivos()
        {
            bool BolRegistro = false;
            if (!ExisteConexion())
            {
                FilterInfoCollection dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                BolRegistro = objCamara.obtenerDispositivos(ref dispositivos);
                if (BolRegistro == true)
                {
                    ViewCamara.MensajeCamara("Se han listado correctamente todos los dispositivos disponibles", 2);
                    ViewCamara.videoDevices = dispositivos;
                }
                else
                    ViewCamara.MensajeCamara("Ocurrio un problema al listar", 3);
            }
            else {
                ViewCamara.MensajeCamara("Hay conexciones verifique ", 1);
            }
        }

 

        public void EstadoCamara(string cadena)
        {
            bool BolRegistro = true;
            if (ExisteConexion())
            {

                if (BolRegistro)
                {
                    ViewCamara.MensajeCamara("Se han listado correctamente todos los dispositivos disponibles", 2);

                    ViewCamara.videoDevice = new VideoCaptureDevice(cadena);
                }
                else
                    ViewCamara.MensajeCamara("Ocurrio un problema al listar", 3);
            }
            else
            {
                ViewCamara.MensajeCamara("Hay conexciones verifique ", 1);
            }
        }






    }
}
