using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PDS_SistemLab2._0.Database2._0
{
    public class Conexao2
    {
         private static string host = "localhost";

        private static string port = "3306";

        private static string password = "root";

        private static string user = "root";

        private static string bdname = "bd_sistemlab";

        private static MySqlConnection connection;

        private static MySqlCommand command;


        public Conexao2()
        {
            try
            {
                connection = new MySqlConnection($"server={host};user={user};database={bdname};port={port};password={password}");
                connection.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public MySqlCommand Query()
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;

                return command;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Close()
        {
            connection.Close();
        }
    }
}
