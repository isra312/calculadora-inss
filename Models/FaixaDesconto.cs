using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class FaixaDesconto
    {
        public FaixaDesconto(decimal min, decimal max, decimal aliquota)
        {
            Min = min;
            Max = max;
            percentualDesconto = aliquota;
        }

        public decimal Min { get;}
        public decimal Max { get;}
        public decimal percentualDesconto { get; }
    }
}
