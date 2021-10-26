using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDS_SistemLab2._0.Interface2;
using PDS_SistemLab2._0.Database2._0;
namespace PDS_SistemLab2._0.Models2._0
{
    class Pedidos_PacientesDAO : IDAO2<Pedidos_Pacientes>
    {
        private static Conexao2 conn;

        public Pedidos_PacientesDAO()
        {
            conn = new Conexao2();
        }
        public void Delete(Pedidos_Pacientes t)
        {
            throw new NotImplementedException();
        }

        public Pedidos_Pacientes GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Pedidos_Pacientes t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO pedidos_pacientes  (descricao_ped,tipo_ped,paciente) " + "VALUES (@Descricaopedido,@Tipopedido)";

                query.Parameters.AddWithValue("@Descricaopedido", t.Descricaopedido);
                query.Parameters.AddWithValue("@Tipopedido", t.Tipopedido);

                var result = query.ExecuteNonQuery();

                if (result == 0)

                    throw new Exception("o registro foi realizado com sucesso!!");

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

        public List<Pedidos_Pacientes> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Pedidos_Pacientes t)
        {
            throw new NotImplementedException();
        }
    }
}
