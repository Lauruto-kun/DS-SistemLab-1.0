using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDS_SistemLab2._0.Models2._0
{
    public class Funcionario
    {
        public int Id{ get; set; }
        public string CPF { get; set; }
        public string Logradouro{ get; set; }
        public  string Atuacao { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Nome { get; set; }
        public int  CEP { get; set; }
        public int Telefone { get; set; }
 
        public DateTime Datanas { get; set; }
    }
}
