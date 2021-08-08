using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class TabelaRepositorioDummy : ITabelaRepositorio
    {
        public TabelaAno CarregarTabelaInss(int ano)
        {
            var tabela = new InssCalcDataDummy().TabelasAnuaisInss.Find(anoCalculo => anoCalculo.Ano == ano);

            if (tabela is null)
                throw new ArgumentNullException("Tabela de cálculo não encontrada para o ano informado.");

            return tabela;
        }
    }
}
