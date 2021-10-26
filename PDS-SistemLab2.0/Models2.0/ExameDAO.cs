using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDS_SistemLab2._0.Models2._0;
using PDS_SistemLab2._0.Database2._0;
using PDS_SistemLab2._0.Interface2;
namespace PDS_SistemLab2._0.Models2._0
{
    class ExameDAO:IDAO2<Exame>
    {
        private static Conexao2 conn;

        public ExameDAO()
        {
            conn = new Conexao2();
        }

        public void Delete(Exame t)
        {
            throw new NotImplementedException();
        }

        public Exame GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Exame t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO exame  (exame,resultado) " + "VALUES (@Exames,@Resultado)";

                query.Parameters.AddWithValue("@Exames", t.Exames); 
                query.Parameters.AddWithValue("@Resultado", t.Resultado);
                 

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

        public List<Exame> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Exame t)
        {
            throw new NotImplementedException();
        }
    }
}
