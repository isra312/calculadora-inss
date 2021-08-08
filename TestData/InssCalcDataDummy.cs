using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class InssCalcDataDummy
    {
        public List<TabelaAno> TabelasAnuaisInss { get; }

        public InssCalcDataDummy(bool testData = false)
        {
            TabelasAnuaisInss = new List<TabelaAno>
            {
                GenerateTabela2011(),
                GenerateTabela2012(),
                GenerateTabela2021()
            };
        }

        private TabelaAno GenerateTabela2011()
        {
            List<FaixaDesconto> faixas = new List<FaixaDesconto>
            {
                new FaixaDesconto(0.00m, 1106.90m, 0.08m),
                new FaixaDesconto(1106.90m, 1844.83m, 0.09m),
                new FaixaDesconto(1844.83m, 3689.66m, 0.11m)
            };

            return new TabelaAno(2011, faixas, 405.86m);
        }

        private TabelaAno GenerateTabela2012()
        {
            List<FaixaDesconto> faixas = new List<FaixaDesconto>
            {
                new FaixaDesconto(0.00m, 1000.00m, 0.07m),
                new FaixaDesconto(1000.01m, 1500.00m, 0.08m),
                new FaixaDesconto(1500.01m, 3000.00m, 0.09m),
                new FaixaDesconto(3000.01m, 4000.00m, 0.11m)
            };

            return new TabelaAno(2012, faixas, 500.00m);
        }

        private TabelaAno GenerateTabela2021()
        {
            List<FaixaDesconto> faixas = new List<FaixaDesconto>
            {
                new FaixaDesconto(0.00m, 1100.00m, 0.075m),
                new FaixaDesconto(1100.01m, 2203.48m, 0.09m),
                new FaixaDesconto(2203.49m, 3305.22m, 0.12m),
                new FaixaDesconto(3305.23m, 6433.57m, 0.14m)
            };

            return new TabelaAno(2021, faixas, 751.99m);
        }
    }
}
