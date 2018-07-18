using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Model;
using Core.View;
using System.Data;
using System.Data.SqlClient;

namespace Core.Presenter
{
    public class WLibro
    {

        //variables
        ManagerBD Manager;
        ILibro ViewLibro;
     

        //constractor
        public WLibro(ILibro InterfazLibro)
        {
          
            Manager = new ManagerBD();

            ViewLibro = InterfazLibro;
        }



        public bool ExisteConexion()
        {
            bool ConexcionAvierta = false;
            SqlConnection sqlCon = Manager.GetConnection();
            if (sqlCon.State == ConnectionState.Open)
            {
                ConexcionAvierta = true;
            }
            return ConexcionAvierta;
        }

        public void Reguistrar()
        {
            bool BolRegistro = false;
            if (ExisteConexion())
            {
            //    BolRegistro = objLibro.reguistro(1, objLibro);
                if (BolRegistro == true)
                    ViewLibro.Mensaje("Libro registrado", 1);
                else
                    ViewLibro.Mensaje("Libro no reguistrado", 1);
            }


        }

        public void Listar(int opcion)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
             //   ExistenDatos = objLibro.listar(opcion, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewLibro.ListaddoLibro = dtsDatos;
                else
                    ViewLibro.Mensaje("No hay reguistros", 2);
            }
            else
            {
                ViewLibro.Mensaje("No hay conexion en red", 2);
            }

        }
    }
}
