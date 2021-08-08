using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class TabelaAno
    {
        public TabelaAno(int ano, List<FaixaDesconto> faixas, decimal teto)
        {
            this.Ano = ano;
            this.Faixas = faixas;
            this.Teto = teto;
        }

        public int Ano { get;}
        public List<FaixaDesconto> Faixas { get; }
        public decimal Teto { get;}

    }
}
