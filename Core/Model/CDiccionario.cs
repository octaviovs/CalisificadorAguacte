using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using Core.Model;

namespace Core.Model
{
    public class CDiccionario
    {

        ManagerBD objManagerBD;
        public string procedimiento= "procesos";
        public CDiccionario()
        {
            objManagerBD = new ManagerBD();
        }
        public bool listar(int opcion, ref DataSet objDatos, CDiccionario objDiccionario)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            objDatos = objManagerBD.GetData(procedimiento, lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;
            
            return ExisteDatos;
        }
        public bool insert(int opcion, CDiccionario objDiccionario)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@datoA", SqlDbType.VarChar) { Value = objDiccionario.datoA });
            lstParametros.Add(new SqlParameter("@datoB", SqlDbType.VarChar) { Value = objDiccionario.datoB });
            lstParametros.Add(new SqlParameter("@datoC", SqlDbType.VarChar) { Value = objDiccionario.datoC });
            lstParametros.Add(new SqlParameter("@datoD", SqlDbType.VarChar) { Value = objDiccionario.datoD });

            //falta
            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData(procedimiento, lstParametros.ToArray()))
                return true;
            return false;
        }

        #region Propiedades
        public int pk_dato { get; set; }
        public int datoA { get; set; }
        public int datoB { get; set; }
        public int datoC{ get; set; }
        public int datoD { get; set; }
        #endregion
    }
}
