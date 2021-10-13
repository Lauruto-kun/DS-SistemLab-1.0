using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_Desenvolvimento_de_Software.Models
{
    public class Financeiro
    {
        public int Id_fin { get; set; }
        public DateTime Data_entrega { get; set; }
        public float Valor_liq { get; set; }
        public float Valor_but { get; set; }

    }
}
