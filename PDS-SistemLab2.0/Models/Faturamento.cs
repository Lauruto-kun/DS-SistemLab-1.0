using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_Desenvolvimento_de_Software.Models
{
    class Faturamento
    {
        public int Id { get; set; }

        public int Custoexame { get; set; }
        
        public DateTime Datarealizacao { get; set; }
        
        public DateTime Datachegada { get; set; }
        
        public int Contaspagar { get; set; }
        
        public int Contasrecebimento { get; set; }
    }
}
