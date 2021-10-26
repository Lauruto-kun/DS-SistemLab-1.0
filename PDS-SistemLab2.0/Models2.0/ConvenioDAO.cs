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
    class ConvenioDAO:IDAO2<Convenio>
    {

        private static Conexao2 conn;
        public ConvenioDAO()
        {
            conn = new Conexao2();
        }

        public void Delete(Convenio t)
        {
            throw new NotImplementedException();
        }

        public Convenio GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Convenio t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO convenio  (CNPG_do_cli_conv,tipo_conv) " + "VALUES (@CNPJ,@TipoConvenio)";

                query.Parameters.AddWithValue("@CNPJ", t.CNPJ);  
                query.Parameters.AddWithValue("@TipoConvenio", t.TipoConvenio);
                

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

        public List<Convenio> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Convenio t)
        {
            throw new NotImplementedException();
        }
    }
}
