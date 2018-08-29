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
        public string procedimiento = "procesos";
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

        public bool EsMaduro(int opcion, ref DataSet objDatos, CDiccionario objDiccionario)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@valueAr", SqlDbType.Int) { Value = objDiccionario.valueAr });
            lstParametros.Add(new SqlParameter("@valueBr", SqlDbType.Int) { Value = objDiccionario.valueBr });
            lstParametros.Add(new SqlParameter("@valueCr", SqlDbType.Int) { Value = objDiccionario.valueCr });
            lstParametros.Add(new SqlParameter("@valueDr", SqlDbType.Int) { Value = objDiccionario.valueDr });

            lstParametros.Add(new SqlParameter("@valueAv", SqlDbType.Int) { Value = objDiccionario.valueAv });
            lstParametros.Add(new SqlParameter("@valueBv", SqlDbType.Int) { Value = objDiccionario.valueBv });
            lstParametros.Add(new SqlParameter("@valueCv", SqlDbType.Int) { Value = objDiccionario.valueCv });
            lstParametros.Add(new SqlParameter("@valueDv", SqlDbType.Int) { Value = objDiccionario.valueDv });

            lstParametros.Add(new SqlParameter("@valueAa", SqlDbType.Int) { Value = objDiccionario.valueAa });
            lstParametros.Add(new SqlParameter("@valueBa", SqlDbType.Int) { Value = objDiccionario.valueBa });
            lstParametros.Add(new SqlParameter("@valueCa", SqlDbType.Int) { Value = objDiccionario.valueCa });
            lstParametros.Add(new SqlParameter("@valueDa", SqlDbType.Int) { Value = objDiccionario.valueDa });



            objDatos = objManagerBD.GetData(procedimiento, lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;

            return ExisteDatos;
        }

        public bool insert(int opcion, CDiccionario objDiccionario)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@valueAr", SqlDbType.VarChar) { Value = objDiccionario.valueAr });
            lstParametros.Add(new SqlParameter("@valueBr", SqlDbType.VarChar) { Value = objDiccionario.valueBr });
            lstParametros.Add(new SqlParameter("@valueCr", SqlDbType.VarChar) { Value = objDiccionario.valueCr });
            lstParametros.Add(new SqlParameter("@valueDr", SqlDbType.VarChar) { Value = objDiccionario.valueDr });


            lstParametros.Add(new SqlParameter("@valueAv", SqlDbType.VarChar) { Value = objDiccionario.valueAv});
            lstParametros.Add(new SqlParameter("@valueBv", SqlDbType.VarChar) { Value = objDiccionario.valueBv });
            lstParametros.Add(new SqlParameter("@valueCv", SqlDbType.VarChar) { Value = objDiccionario.valueCv });
            lstParametros.Add(new SqlParameter("@valueDv", SqlDbType.VarChar) { Value = objDiccionario.valueDv });

            lstParametros.Add(new SqlParameter("@valueAa", SqlDbType.VarChar) { Value = objDiccionario.valueAa });
            lstParametros.Add(new SqlParameter("@valueBa", SqlDbType.VarChar) { Value = objDiccionario.valueBa });
            lstParametros.Add(new SqlParameter("@valueCa", SqlDbType.VarChar) { Value = objDiccionario.valueCa });
            lstParametros.Add(new SqlParameter("@valueDa", SqlDbType.VarChar) { Value = objDiccionario.valueDa });
            lstParametros.Add(new SqlParameter("@tipo", SqlDbType.VarChar) { Value = objDiccionario.tipo });


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
        public int datoC { get; set; }
        public int datoD { get; set; }
        public int tipo { get; set; }


        public int valueAr { get; set; }
        public int valueBr { get; set; }
        public int valueCr { get; set; }
        public int valueDr { get; set; }
        public int valueAv { get; set; }
        public int valueBv { get; set; }
        public int valueCv { get; set; }
        public int valueDv { get; set; }
        public int valueAa { get; set; }
        public int valueBa { get; set; }
        public int valueCa { get; set; }
        public int valueDa { get; set; }
        #endregion
    }
}
