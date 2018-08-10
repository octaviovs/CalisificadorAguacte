/**
 * Archivo: ManagerBD.CS
 * Autor: MHR
 * Fecha: 30/01/2017
 * Descripción: Contiene metodos de Conexión, Acceso y Actualización de BD.   
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Librerias
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Core.Model
{
    public class ManagerBD
    {

        public string strCadenaConexion
        { get; set; }

        public ManagerBD()
        {
            strCadenaConexion = ConfigurationManager.ConnectionStrings["Frutas"].ConnectionString;

        }

        /// <summary>
        /// Autor: MHR
        /// Constructor que inicializa la cadena de Conexión
        /// </summary>
        /// <param name="strNombreConexion"></param>
        public ManagerBD(string strNombreConexion)
        {

            //strCadenaConexion = ConfigurationManager.ConnectionStrings[strNombreConexion].ConnectionString;
        }

        /// <summary>
        /// Autor: MHR
        /// Obtiene la Cadena de Conexión y abre una conexión con la BD
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            SqlConnection sqlConexionBD = new SqlConnection(strCadenaConexion);

            try
            {
                sqlConexionBD.Open();
            }
            catch (Exception)
            {
                sqlConexionBD.Close();
                //throw;
            }

            return sqlConexionBD;
        }

        /// <summary>
        /// Autor: MHR
        /// Realiza la consulta de datos de acuerdo a los parametros de Busqueda recibidos
        /// </summary>
        /// <param name="spStoreProcedure">Nombre del Procemiento Almacenado</param>
        /// <param name="sqlParameters">Lista de parametros</param>
        /// <returns>Colección de Datos</returns>
        public DataSet GetData(string spStoreProcedure, SqlParameter[] sqlParameters)
        {
            SqlConnection sqlConexion = null;
            SqlCommand sqlComman = null;
            SqlDataAdapter sqlDataAdapter;
            DataSet datColeccionDatos = new DataSet();

            try
            {
                sqlConexion = GetConnection();
                using (sqlConexion)
                {
                    sqlComman = new SqlCommand(spStoreProcedure, sqlConexion);
                    using (sqlComman)
                    {
                        sqlComman.CommandType = CommandType.StoredProcedure;

                        if (sqlParameters != null)
                            sqlComman.Parameters.AddRange(sqlParameters);

                        sqlDataAdapter = new SqlDataAdapter(sqlComman);
                        sqlDataAdapter.Fill(datColeccionDatos, "Datos");
                    }
                }
            }
            catch (Exception exeExcepcion)
            {
                exeExcepcion.Message.ToString();
                //throw;
            }
            finally
            {
                if (sqlConexion != null)
                {
                    if (sqlConexion.State == ConnectionState.Open)
                        sqlConexion.Close();
                }
            }

            return datColeccionDatos;
        }


        /// <summary>
        /// Autor: MHR
        /// Operaciones: Insertar, Modificar y Eliminar Datos en la BD.
        /// </summary>
        /// <param name="spStoreProcedure">Nombre del Procedimiento Almacenado</param>
        /// <param name="sqlParameters">Lista de parametros</param>
        /// <returns>Verdadero / Falso: Datos Registrados</returns>
        public bool UpdateData(string spStoreProcedure, SqlParameter[] sqlParameters)
        {
            SqlConnection sqlConexion = null;
            SqlCommand sqlComman = null;
            SqlTransaction sqlTransaction = null;
            int intRegistrosAfectados = 0;
            bool bolRegisterData = false;

            try
            {
                sqlConexion = this.GetConnection();
                using (sqlConexion)
                {
                    sqlTransaction = sqlConexion.BeginTransaction();
                    sqlComman = new SqlCommand(spStoreProcedure, sqlConexion);
                    using (sqlComman)
                    {
                        sqlComman.Transaction = sqlTransaction;
                        sqlComman.CommandType = CommandType.StoredProcedure;

                        if (sqlParameters != null)
                            sqlComman.Parameters.AddRange(sqlParameters);

              
                        intRegistrosAfectados = sqlComman.ExecuteNonQuery();
                        sqlTransaction.Commit();
                    }

                    if (intRegistrosAfectados > 0 )// //https://msdn.microsoft.com/es-es/library/system.data.sqlclient.sqlcommand.executenonquery(v=vs.100).aspx
                        bolRegisterData = true;
                }
            }
            catch (Exception exExcepcion1)
            {
                try
                {
                    sqlTransaction.Rollback();
                    //throw;
                }
                catch (Exception exExcepcion2)
                {
                    exExcepcion2.Message.ToString();
                    //throw;
                }

                exExcepcion1.Message.ToString();
            }
            finally
            {
                if (sqlConexion != null)
                {
                    if (sqlConexion.State == ConnectionState.Open)
                        sqlConexion.Close();
                }
            }


            return bolRegisterData;
        }


    }
}
