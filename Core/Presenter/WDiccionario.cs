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
    public class WDiccionario
    {
        ManagerBD Manager;
        IDiccionario ViewDiccionario;
        CDiccionario objDiccionario;
        public WDiccionario(IDiccionario InterfazDiccionario)
        {
            objDiccionario = new CDiccionario();
            Manager = new ManagerBD();
            ViewDiccionario = InterfazDiccionario;
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

    
        public void Reguistrar(int op, CDiccionario obj)
        {
            bool BolRegistro = false;

            if (ExisteConexion())
                BolRegistro = objDiccionario.insert(op, obj);

            if (BolRegistro == true)
            {
                ViewDiccionario.MensajeDiccionario("Se registro",1);
            }
            else
            {
                ViewDiccionario.MensajeDiccionario("No se registro", 2);

            }
        }

        public void EsMaduro( int opcion, CDiccionario datos )
        {
            DataSet dtsDatos = new DataSet();
            CDiccionario objaux = new CDiccionario();

            bool BolRegistro = false;
            if (ExisteConexion())
            {
                BolRegistro = objaux.EsMaduro(opcion,  ref dtsDatos, datos);

                if (BolRegistro == true)
                {
                    ViewDiccionario.DatosDT = dtsDatos;
                    string a = dtsDatos.Tables[0].Rows[0][0].ToString();
                    string b = dtsDatos.Tables[0].Rows[0][1].ToString();

                    ViewDiccionario.MensajeDiccionario(a+"|"+b, 6);
                }
                else
                {
                    ViewDiccionario.MensajeDiccionario(" ", 0);
                }
            }
        }
    }
}
