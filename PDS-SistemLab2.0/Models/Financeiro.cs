using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_Desenvolvimento_de_Software.Models
{
    public class Financeiro
    {
        public int Idfinanceiro { get; set; }
        public DateTime Dataentrega { get; set; }
        public float Valorliquido { get; set; }
        public float Valorbruto { get; set; }

    }
}
