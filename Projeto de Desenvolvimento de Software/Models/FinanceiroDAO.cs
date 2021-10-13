using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_de_Desenvolvimento_de_Software.Interface;
using Projeto_de_Desenvolvimento_de_Software.Database;
namespace Projeto_de_Desenvolvimento_de_Software.Models
{
    class FinanceiroDAO : IDAO<Financeiro>
    {
        private static Conexao conn;

        public FinanceiroDAO()
        {
            conn = new Conexao();
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
                query.CommandText = "INSERT INTO pedidos_pacientes  (descricao_ped,tipo_ped,id_pa_fk) " + "VALUES (@Descricao_ped,@Tipo_ped,@Id_pa_fk)";

                query.Parameters.AddWithValue("@Data_entrega", t.Data_entrega.ToString("yyyy-MM-dd")); //"10/11/1998 -> "1998-11-10"    
                 query.Parameters.AddWithValue("@Valor_but", t.Valor_but);
                query.Parameters.AddWithValue("@Valor_liq", t.Valor_liq);

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

        public List<Financeiro> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Financeiro t)
        {
            throw new NotImplementedException();
        }
    }
