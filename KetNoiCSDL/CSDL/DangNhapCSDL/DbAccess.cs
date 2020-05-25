using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DangNhapCSDL
{
    class DbAccess
    {
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataReader DbReader;
        private static SqlDataAdapter adapter = new SqlDataAdapter();

        private static string strConnString =
            "Data Source= COMPUTER-PC\\SQLEXPRESS; Initial Catalog = NetworkSocial; Integrated Security = True;";

        public void createConn()
        {
            try
            {
                if(connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch(Exception ex){
                throw ex;
            }
        }
        public int executeQuery(SqlCommand dbCommand)
        {
            try{
                if(connection.State == 0)
                {
                    createConn();
                }
                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;
                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void readDatathroughAdapter(string query, System.Data.DataTable tblName)
        {
            try
            {
                if(connection.State == ConnectionState.Closed)
                {
                    createConn();
                }
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
            }
            catch(Exception ex) {
                throw ex;
            }
        }
    }
}
