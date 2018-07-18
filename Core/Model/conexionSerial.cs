using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace Core.Model
{
    public  class conexionSerial
    {
        // Declaramos un atributo del mismo tipo de la clase con carácter estático

        private static conexionSerial _instancia = null;

        public string Nombre { get; set; }
        public string Puerto { get; set; }

        public SerialPort miPuerto { get; set; }
        public DateTime HoraArranque { get; set; }



        // Constructor privado. Únicamente puede ser invocado desde el interior
        // de la propia clase
        private conexionSerial()
        {
            Nombre = "Patrón Singleton";
            HoraArranque = DateTime.Now;
            miPuerto = new SerialPort();
        }

        // Property de solo lectura
        public static conexionSerial Instance
        {
            get
            {
                // Si el singleton no ha sido creado previamente, se instancia.
                // En caso contrario, se devolvera el que haya sido creado previamente
                if (_instancia == null)
                    _instancia = new conexionSerial();

                // Se devuelve la instancia
                return _instancia;
            }
        }

        public bool obtenerPuertos(ref List<string> ports) {

            string[] conexiones = SerialPort.GetPortNames();
            foreach (var item in conexiones)
            {
                ports.Add(item);
            }

            if (conexiones.Length > 0)
                return true;
            else
                return false;

        }

        public bool puertoActivo(string datos)
        {

            bool bandera = true; ;

            try
            {
                this.miPuerto.Write(datos);
            }
            catch (Exception)
            {
                bandera = false;
            }


            return bandera;


        }


        public bool setDato(string datos)
        {

            bool bandera = true; ;

            try
            {
                this.miPuerto.Write(datos);
            }
            catch (Exception)
            {
                bandera = false;
            }


            return bandera;


        }

        public bool getDato( ref string info,string datos)
        {
            bool bandera = false;
            try {

                info = miPuerto.ReadExisting();
                bandera = (string.IsNullOrEmpty(info)) ? false:true;
            


            }
            catch (Exception)
            {
                bandera = false;
            }

            return bandera;
        }
       

    }
}


