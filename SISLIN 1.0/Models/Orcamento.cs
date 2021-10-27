using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISLIN_1._0.Models
{
    class Orcamento
    {
        public int ID { get; set; }

        public DateTime Data { get; set; }

        public string Descrisao { get; set; }

        public int Desconto { get; set; }

        public int Unidade { get; set; }

        public int Quantdd { get; set; }

        public double Valor { get; set; }

    }
}
