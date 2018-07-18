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
    public class CLibro
    {
        //propiedades
        public int Clave { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public double Precio { get; set; }
        ManagerBD objManagerBD;
        ///metodos
        //
        public CLibro()
        {
            objManagerBD = new ManagerBD();
        }
        public bool reguistro(int opcion, CLibro obj)
        {

            List<SqlParameter> lstParametros = new List<SqlParameter>();

            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@Titulo", SqlDbType.NVarChar, 50) { Value = obj.Titulo });
            lstParametros.Add(new SqlParameter("@Autor", SqlDbType.NVarChar, 50) { Value = obj.Autor });
            lstParametros.Add(new SqlParameter("@Isbn", SqlDbType.NVarChar, 50) { Value = obj.ISBN });
            lstParametros.Add(new SqlParameter("@Precio", SqlDbType.Money) { Value = obj.Precio });

            objManagerBD = new ManagerBD();

            if (objManagerBD.UpdateData("MiCuestionario", lstParametros.ToArray()))
                return true;


            return false;
        }


        public bool listar(int opcion, ref DataSet objDatos)
        {

            bool ExisteDatos = false;
            List<SqlParameter> lsParametros = new List<SqlParameter>();
            lsParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });

            objDatos = objManagerBD.GetData("spTransacciones", lsParametros.ToArray());

            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;

            return ExisteDatos;
        }
    }
}
