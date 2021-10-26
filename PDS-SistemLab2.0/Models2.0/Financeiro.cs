using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDS_SistemLab2._0.Models2._0
{
    public class Financeiro
    {
        public int Idfinanceiro { get; set; }
        public DateTime Dataentrega { get; set; }
        public float Valorliquido { get; set; }
        public float Valorbruto { get; set; }
    }
}
