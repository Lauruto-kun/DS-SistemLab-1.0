using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_Desenvolvimento_de_Software.Models
{
    public class Pedidos_medico
    {
        public int Id_ped_med { get; set; }

        public int Id_med_fk { get; set; }

        public int Id_ped_fk { get; set; }


    }
}
