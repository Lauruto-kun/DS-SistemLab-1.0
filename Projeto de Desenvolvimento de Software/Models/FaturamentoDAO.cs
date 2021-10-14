using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_de_Desenvolvimento_de_Software.Interface;
using Projeto_de_Desenvolvimento_de_Software.Database;
using Projeto_de_Desenvolvimento_de_Software.Models;

namespace Projeto_de_Desenvolvimento_de_Software.Models
{
    class FaturamentoDAO : IDAO<Faturamento>
    {
        private static Conexao conn; 
        public FaturamentoDAO()
        {
            conn = new Conexao();
        }

        public void Delete(Faturamento t)
        {
            throw new NotImplementedException();
        }

        public Faturamento GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Faturamento t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO pedidos_pacientes  (descricao_ped,tipo_ped,id_pa_fk) " + "VALUES (@Custo,@Datachegada,@Datarealizacao,@Contaspaga,@Contasrecebimento)";

                query.Parameters.AddWithValue("@Datachegada", t.Datachegada.ToString("yyyy-MM-dd")); //"10/11/1998 -> "1998-11-10"    
                query.Parameters.AddWithValue("@Custo", t.Custoexame);
                query.Parameters.AddWithValue("@Datarealizacao", t.Datarealizacao.ToString("yyyy-MM-dd"));
                query.Parameters.AddWithValue("@Contaspaga", t.Contaspagar);
                query.Parameters.AddWithValue("@Contasrecebimento", t.Contasrecebimento);

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

        public List<Faturamento> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Faturamento t)
        {
            throw new NotImplementedException();
        }
    }
}
