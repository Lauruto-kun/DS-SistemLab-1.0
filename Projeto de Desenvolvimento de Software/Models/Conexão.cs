using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_de_Desenvolvimento_de_Software.Conexão
{
  public  class Conexão
    {
        private static string host = "localhost";

        private static string port = "3306";

        private static string password = "01272852296mat";

        private static string user = "root";

        private static string bdname = "bd_sistemlab";

        private static MySqlConnection connection;

        private static MySqlCommand command;


        public Conexão()
        {
            try
            {
                connection = new MySqlConnection($"server={host};user{user};database{bdname};port{port};password{password}");
                connection.Open();
            }catch (Exception)
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
