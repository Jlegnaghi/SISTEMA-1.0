using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace SISTEMA_1._0.DAL
{
    internal class DAL_Conn
    {
        // Atributos de conexão
        private static string connectionStringMySQL = "server=jeffersonlegnaghi.com.br;port=3306;database=jefferso_sistema_1.0;uid=jefferso_legnaghi;password=UGL!udc00$";
        //private static string connectionStringSQLServer = "Server=seuServidor;Database=seuBanco;User Id=seuUsuario;Password=suaSenha;";

        // Método para obter a conexão MySQL
        public static MySqlConnection GetConnectionMySQL()
        {
            MySqlConnection conn = new MySqlConnection(connectionStringMySQL);
            return conn;
        }

        // Método para obter a conexão MS SQL Server
        //public static SqlConnection GetConnectionSQLServer()
        //{
        //    SqlConnection conn = new SqlConnection(connectionStringSQLServer);
        //    return conn;
        //}
    }
}