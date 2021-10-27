using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISLIN_1._0.Models
{
    class EntrDinheiro
    {
        public int Id_Dinheiro { get; set; }
        public double Valor_Dinheiro { get; set; }
        public string formapaga_Dinheiro { get; set; }
        public DateTime Data { get; set; }
    }
}
