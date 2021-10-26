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
    class VendaDAO : IDAO2<Venda>
    {
        private static Conexao2 conn;

        public VendaDAO()
        {
            conn = new Conexao2();
        }
        public void Delete(Venda t)
        {
            throw new NotImplementedException();
        }

        public Venda GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Venda t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO venda  (data_exa,valor_exa,quant_exa) " + "VALUES (@DataExame,@QuantExame,@ValorExame)";

                query.Parameters.AddWithValue("@DataExame", t.DataExame);
                query.Parameters.AddWithValue("@QuantExame", t.QuantExame);
                query.Parameters.AddWithValue("@ValorExame", t.ValorExame);
                



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

        public List<Venda> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Venda t)
        {
            throw new NotImplementedException();
        }
    }
}
