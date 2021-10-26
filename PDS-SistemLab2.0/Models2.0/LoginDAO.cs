using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDS_SistemLab2._0.Database2._0;
using PDS_SistemLab2._0.Interface2;
using PDS_SistemLab2._0.Models2._0;

namespace PDS_SistemLab2._0.Models2._0
{
    class LoginDAO : IDAO2<Login>
    {
        private static Conexao2 conn;

        public LoginDAO()
        {
            conn = new Conexao2();
        }

        public void Delete(Login t)
        {
            throw new NotImplementedException();
        }

        public Login GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Login t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO exame  (login,senha) " + "VALUES (@Login,@Senha)";

                query.Parameters.AddWithValue("@Login", t.Login);
                query.Parameters.AddWithValue("@Senha", t.Senha);


                var result = query.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Login> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Login t)
        {
            throw new NotImplementedException();
        }
    }
}
