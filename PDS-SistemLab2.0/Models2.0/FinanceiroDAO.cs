using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDS_SistemLab2._0.Database2._0;
using PDS_SistemLab2._0.Interface2;
using PDS_SistemLab2._0.Models2;

namespace PDS_SistemLab2._0.Models2._0
{
    class FinanceiroDAO : IDAO2<Financeiro >
    {
        private static Conexao2 conn;

        public FinanceiroDAO()
        {
            conn = new Conexao2();
        }
        public void Delete(Financeiro t)
        {
            throw new NotImplementedException();
        }

        public Financeiro GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Financeiro t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO pedidos_pacientes  (descricao_ped,tipo_ped,id_pa_fk) " + "VALUES (@Dataentrega,@Valorbruto,@Valorliquido)";

                query.Parameters.AddWithValue("@Dataentrega", t.Dataentrega.ToString("yyyy-MM-dd")); //"10/11/1998 -> "1998-11-10"    
                query.Parameters.AddWithValue("@Valorbruto", t.Valorbruto);
                query.Parameters.AddWithValue("@Valorliquido", t.Valorliquido);

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

        public List<Financeiro> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Financeiro t)
        {
            throw new NotImplementedException();
        }
    }

}
