using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_Desenvolvimento_de_Software.Models
{
    class Faturamento
    {
        public int Id_fat { get; set; }
        public int Custo_exa_fat { get; set; }
        public DateTime Data_real_fat { get; set; }
        public DateTime Data_cheg_fat { get; set; }
        public int Contas_pag { get; set; }
        public int Contas_rec { get; set; }
        public int Id_fin_fk { get; set; }




    }
}
