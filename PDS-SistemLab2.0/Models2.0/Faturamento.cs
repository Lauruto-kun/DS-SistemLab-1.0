using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDS_SistemLab2._0.Models2._0
{
    public  class Faturamento
    {
        public int Id { get; set; }

        public float Custoexame { get; set; }

        public DateTime Datarealizacao { get; set; }

        public DateTime Datachegada { get; set; }

        public float Contaspagar { get; set; }

        public float Contasrecebimento { get; set; }
        //ID_FIN_FK
    }
}
