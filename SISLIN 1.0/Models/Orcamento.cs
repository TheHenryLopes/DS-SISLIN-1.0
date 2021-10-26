using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISLIN_1._0.Models
{
    class Orcamento
    {

        /*
         *ID -> id_orcamento 
         * Data -> data_orcamento
         * Valor -> valor_orcamento
         * Via -> via_orcamento
         */

        public int ID { get; set; }

        public DateTime Data { get; set; }

        public double Valor { get; set; }

        public int Via { get; set; }
    }
}
