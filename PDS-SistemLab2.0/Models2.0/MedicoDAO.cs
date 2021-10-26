using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDS_SistemLab2._0.Database2._0;
using PDS_SistemLab2._0.Models2._0;
using PDS_SistemLab2._0.Interface2;
namespace PDS_SistemLab2._0.Models2._0
{
    class MedicoDAO : IDAO2<Medico>
    {
        private static Conexao2 conn;

        public MedicoDAO()
        {
            conn = new Conexao2();
        }
        public void Delete(Medico t)
        {
            throw new NotImplementedException();
        }

        public Medico GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Medico t)
        {

            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO medico  (cpf_med,RG_med,nome_med,logradouro_med,cep_med) " + "VALUES (@CPF,@RG,@Nome,@Logradouro,@CEP)";

                query.Parameters.AddWithValue("@CPF", t.CPF);
                query.Parameters.AddWithValue("@RG", t.RG);
                query.Parameters.AddWithValue("@Nome", t.Nome);
                query.Parameters.AddWithValue("@Logradouro", t.Logradouro);
                query.Parameters.AddWithValue("@CEP", t.CEP);



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

        public List<Medico> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Medico t)
        {
            throw new NotImplementedException();
        }
    }
}
