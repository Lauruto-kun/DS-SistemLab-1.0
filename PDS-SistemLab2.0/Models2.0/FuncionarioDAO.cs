using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDS_SistemLab2._0.Models2._0;
using PDS_SistemLab2._0.Interface2;
using PDS_SistemLab2._0.Database2._0;
namespace PDS_SistemLab2._0.Models2._0
{
    class FuncionarioDAO:IDAO2<Funcionario>
    {
       
            private static Conexao2 conn;
            public FuncionarioDAO()
            {
                conn = new Conexao2();
            }

            public void Delete(Funcionario t)
            {
                throw new NotImplementedException();
            }

            public Funcionario GetById(int id)
            {
                throw new NotImplementedException();
            }

            public void Insert(Funcionario t)
            {
                try
                {
                    var query = conn.Query();
                    query.CommandText = "INSERT INTO funcionario  (atuacao_func,cpf_func,logradouro_func,telefone_func,numero_func,cidade_func,nome_func,cep_func,datanas) " + "VALUES (@Atucao,@CPF,@Logradouro,@Telefone,@Numero,@Cidade,@Nome,@CEP,@Datanas)";

                    query.Parameters.AddWithValue("@Atucao", t.Atuacao); //"10/11/1998 -> "1998-11-10"    
                    query.Parameters.AddWithValue("@CEP", t.CEP);
                    query.Parameters.AddWithValue("@Cidade", t.Cidade);
                    query.Parameters.AddWithValue("@CPF", t.CPF);
                    query.Parameters.AddWithValue("@Logradouro", t.Logradouro);
                    query.Parameters.AddWithValue("@Nome", t.Nome);
                    query.Parameters.AddWithValue("@Numero", t.Numero);
                     query.Parameters.AddWithValue("@Telefone", t.Telefone);
                    query.Parameters.AddWithValue("@Datanas", t.Datanas.ToString("yyyy-MM-dd"));


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

            public List<Funcionario> List()
            {
                throw new NotImplementedException();
            }

            public void Update(Funcionario t)
            {
                throw new NotImplementedException();
            }
        
    }
}
