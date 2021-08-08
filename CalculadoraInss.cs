using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class CalculadoraInss : ICalculadorInss
    {
        TabelaAno _tabela;

        public CalculadoraInss(TabelaAno tabela)
        {
            this._tabela = tabela;
        }

        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            Aliquota aliquota = DefinirAliquota(salario);

            if (aliquota.ValorAbsoluto)
                return aliquota.Desconto;

            return salario * aliquota.Desconto;
        }

        Aliquota DefinirAliquota(decimal salario)
        {
            if (salario <= 0.00m)
                return new Aliquota(0.00m, true);

            if (salario > _tabela.Faixas.Max(faixa => faixa.Max))
                return new Aliquota(_tabela.Teto, true);

            decimal percentual = _tabela.Faixas.Find(faixa => faixa.Min <= salario && salario <= faixa.Max).percentualDesconto;

            return new Aliquota(percentual, false);

        }
    }
}
