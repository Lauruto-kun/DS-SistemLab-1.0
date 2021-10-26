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
    class PacintesDAO : IDAO2<Paciente>
    {
        private static Conexao2 conn;

        public PacintesDAO()
        {
            conn = new Conexao2();
        }
        public void Delete(Paciente t)
        {
            throw new NotImplementedException();
        }

        public Paciente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Paciente t)
        {

            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO paciente  (nome_pa,cep_pa,tipo_san_pa,cpf_pa,data_nas_pa,logradouro_pa,numero_pa,rg_pa) " + "VALUES (@Nome,@CEP,@TipoSan,@CPF,@Datanas,@Loagradouro,@Numero,@RG)";

                query.Parameters.AddWithValue("@CPF", t.CPF);
                query.Parameters.AddWithValue("@RG", t.RG);
                query.Parameters.AddWithValue("@Nome", t.Nome);
                query.Parameters.AddWithValue("@Loagradouro", t.Loagradouro);
                query.Parameters.AddWithValue("@CEP", t.CEP);
                query.Parameters.AddWithValue("@Datanas", t.Datanas);
                query.Parameters.AddWithValue("@Numero", t.Numero);
                query.Parameters.AddWithValue("@TipoSan", t.TipoSan);




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

        public List<Paciente> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Paciente t)
        {
            throw new NotImplementedException();
        }
    }
}
