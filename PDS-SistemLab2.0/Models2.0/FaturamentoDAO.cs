using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDS_SistemLab2._0.Database2._0;
using PDS_SistemLab2._0.Interface2;
namespace PDS_SistemLab2._0.Models2._0
{
    class FaturamentoDAO : IDAO2<Faturamento>
    {
        private static Conexao2 conn;
        public FaturamentoDAO()
        {
            conn = new Conexao2();
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
                query.CommandText = "INSERT INTO pedidos_pacientes  (custo_exa_fat,data_reali_fat,data_cheg_fat,contas_pag,contas_rec) " + "VALUES (@Custo,@Datachegada,@Datarealizacao,@Contaspaga,@Contasrecebimento)";

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
