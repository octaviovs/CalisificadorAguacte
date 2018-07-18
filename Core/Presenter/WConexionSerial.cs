using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Model;
using Core.View;

namespace Core.Presenter
{
    public class WConexionSerial
    {
        //variables
        ControlSerial Manager;


        IConexionSerial ViewConexionSerial;
        conexionSerial objConexionSerial;
        public WConexionSerial(IConexionSerial InterfazConexionSerial)
        {
            objConexionSerial = conexionSerial.Instance; //Una unica instancia

            Manager = new ControlSerial();
            ViewConexionSerial = InterfazConexionSerial;
        }


        public bool ExisteConexion()
        {
            bool ConexcionAvierta = false;
            if (objConexionSerial.miPuerto.IsOpen) //verificar si el puerto esta 
                ConexcionAvierta = true;
            return ConexcionAvierta;
        }

        public void ListadoPuertos()
        {
            bool BolRegistro = false;
            if (!ExisteConexion())
            {
                List<string> conexiones =new List<string>();
                BolRegistro = objConexionSerial.obtenerPuertos(ref conexiones);
                if (BolRegistro == true) {
                    ViewConexionSerial.Mensaje("Se han listado correctamente todos los puertos disponibles", 2);
                    ViewConexionSerial.puertos = conexiones;
                } 
                else
                    ViewConexionSerial.Mensaje("No hay puertos COM disponible, verifique sus dispositivos, o las conexiones", 3);
            }



        }

        public void prednerLed(string dato)
        {
            bool BolRegistro = false;
            if (ExisteConexion())
            {
                
                BolRegistro = objConexionSerial.setDato(dato);
                if (BolRegistro == true)
                {
                    ViewConexionSerial.Mensaje("Se han listado correctamente todos los puertos disponibles", 4);
                   
                }
                else
                    ViewConexionSerial.Mensaje("No hay puertos COM disponible, verifique sus dispositivos, o las conexiones", 3);
            }
            else
            {
                ViewConexionSerial.Mensaje("No hay conexions erial", 1);
            }


        }



        public void setDato(string dato)
        {
            bool BolRegistro = false;
            if (ExisteConexion())
            {

                BolRegistro = objConexionSerial.setDato(dato);
                if (BolRegistro == true)
                {
                  

                }
                else
                    ViewConexionSerial.Mensaje("No hay puertos COM disponible, verifique sus dispositivos, o las conexiones", 3);
            }
            else
            {
                ViewConexionSerial.Mensaje("No hay conexions erial", 1);
            }


        }
        public void getDato(string dato)
        {
            bool BolRegistro = false;
            string info = "";
            if (ExisteConexion())
            {
                
                BolRegistro = objConexionSerial.getDato(ref info,dato);
                if (BolRegistro == true)
                {
                    ViewConexionSerial.Mensaje(info,10);
                }
                else
                    ViewConexionSerial.Mensaje("Error", 3);
            }
            else
            {
                ViewConexionSerial.Mensaje("No hay conexions erial", 1);
            }


        }
    }
}
