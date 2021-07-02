using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISLIN_1._0
{
    public class ProdutosPromocao
    {

        public int Id { get; set; }


        public string Produto {get;set;}

        public double Valor_atual { get; set; }

        public double Valor_promo { get; set; }

        public double Porcent { get; set; }

    }
}
