using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_1._0.Data_Layer
{
    internal class DatabaseConnection
    {
        // Defina a string de conexão. Altere para os detalhes do seu banco de dados.
        private static string connectionString = "server=162.241.203.110;database=jefferso_SISTEMA;user=jefferso_legnaghi;password=UGL!udc00$;";

        // Método para obter a conexão com o banco de dados
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
