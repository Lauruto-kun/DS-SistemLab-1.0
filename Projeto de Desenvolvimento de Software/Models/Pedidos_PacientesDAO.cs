using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_de_Desenvolvimento_de_Software.Interface;
using Projeto_de_Desenvolvimento_de_Software.Database;
namespace Projeto_de_Desenvolvimento_de_Software.Models
{
    class Pedidos_PacientesDAO : IDAO<Pedidos_Pacientes>
    {
        private static Conexão conn;

        public Pedidos_PacientesDAO()
        {
            conn = new Conexão();
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
                query.CommandText = "INSERT INTO pedidos_pacientes  (descricao_ped,tipo_ped,id_pa_fk) " + "VALUES (@Descricao_ped,@Tipo_ped,@Id_pa_fk)";

                query.Parameters.AddWithValue("@Descricao_ped",t.Descricao_ped);
                query.Parameters.AddWithValue("@Tipo_ped", t.Tipo_ped);
                query.Parameters.AddWithValue("@Id_pa_fk", t.Id_pa_fk);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                
                    throw new Exception("o registro foi realizado com sucesso!!");
                
            }
            catch (Exception e)
            {
                throw e;
            }finally
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
