using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promobusque.Dominio
{
    public class ConexaoDao
    {
        private static SqlConnection sqlConnection = null;
        private static ConexaoDao objConexaoDao = null;
        private static string connString = null;

        public ConexaoDao()
        {
            string connString = ConfigurationManager.ConnectionStrings["PromobusqueMDF"].ToString().Trim();
            sqlConnection = new SqlConnection(connString);
        }

        public static ConexaoDao GetInstance()
        {
            if (objConexaoDao == null)
            {   
                objConexaoDao = new ConexaoDao();
            }
            return objConexaoDao;
        }

        public void Open()
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
