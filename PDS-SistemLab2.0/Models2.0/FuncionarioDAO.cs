using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDS_SistemLab2._0.Models2._0;
using PDS_SistemLab2._0.Interface2;
using PDS_SistemLab2._0.Database2._0;
using MySql.Data.MySqlClient;
namespace PDS_SistemLab2._0.Models2._0
{
    class FuncionarioDAO : IDAO2<Funcionario>
    {

        private static Conexao2 conn;
        public FuncionarioDAO()
        {
            conn = new Conexao2();
        }

        public void Delete(Funcionario t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "DELETE FROM funcionario WHERE id_func=@id";
 
                query.Parameters.AddWithValue("@id", t.Id); 
               

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("Registro não removido na base de dados");
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

        public Funcionario GetById(int id)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "SELECT * FROM funcionario WHERE id_func=@id";
                query.Parameters.AddWithValue("@id",id);

                MySqlDataReader reader = query.ExecuteReader();
                var funcionario=new Funcionario();


                while (reader.Read())
                {

                    funcionario.Id = reader.GetInt32("id_func");
                    funcionario.Atuacao = reader.GetString("atuacao_func");
                    funcionario.CPF = reader.GetString("cpf_func");
                    funcionario.Logradouro = reader.GetString("logradouro_func");
                    funcionario.Telefone = (int)reader.GetInt64("telefone_func");
                    funcionario.Numero = (int)reader.GetInt64("numero_func");
                    funcionario.Cidade = reader.GetString("cidade_func");
                    funcionario.Nome = reader.GetString("nome_func");
                    funcionario.Datanas = reader.GetDateTime("datanas")

                        ;
                }
                return funcionario;
                



            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Query();
            }

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

                if (result == 0)
                    throw new Exception("A inserção não foi realizada");
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
                try
                {

                   List<Funcionario> list = new List<Funcionario>();

                     var query = conn.Query();
                    query.CommandText = "SELECT * FROM funcionario";
                  MySqlDataReader reader=  query.ExecuteReader();

                    while (reader.Read())
                    {   
                        list.Add(new Funcionario()
                        {
                            Id=reader.GetInt32("id_func"),
                            Atuacao = reader.GetString("atuacao_func"),
                            CPF = reader.GetString("cpf_func"),
                            Logradouro = reader.GetString("logradouro_func"),
                            Telefone = (int)reader.GetInt64("telefone_func"),
                            Numero = (int)reader.GetInt64("numero_func"),
                            Cidade = reader.GetString("cidade_func"),
                            Nome = reader.GetString("nome_func"),
                            CEP = (int)reader.GetInt64("cep_func"),
                            Datanas = reader.GetDateTime("datanas"),
 



                        });
                    }

                 return list;

                }
             catch(Exception e)
             {
                throw e;
             }
            finally
            {
                conn.Close();
            }

          }

            public void Update(Funcionario t)
            {
            try
            {
                var query = conn.Query();
                query.CommandText = "UPDATE funcionario  (SET atuacao_func=@Atucao,cpf_func=@CPF,logradouro_func=@Logradouro," +
                    "telefone_func=@Telefone,numero_func=@Numero,cidade_func=@Cidade,nome_func=@Nome,cep_func=@CEP,datanas=@Datanas) " + "WHERE id_func=@id";

                query.Parameters.AddWithValue("@Atucao", t.Atuacao); //"10/11/1998 -> "1998-11-10"    
                query.Parameters.AddWithValue("@CEP", t.CEP);
                query.Parameters.AddWithValue("@Cidade", t.Cidade);
                query.Parameters.AddWithValue("@CPF", t.CPF);
                query.Parameters.AddWithValue("@Logradouro", t.Logradouro);
                query.Parameters.AddWithValue("@Nome", t.Nome);
                query.Parameters.AddWithValue("@Numero", t.Numero);
                query.Parameters.AddWithValue("@Telefone", t.Telefone);
                query.Parameters.AddWithValue("@Datanas", t.Datanas.ToString("yyyy-MM-dd"));
                query.Parameters.AddWithValue("@id", t.Id);


                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("Atualização no foi realizada");

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
        
    }
}
