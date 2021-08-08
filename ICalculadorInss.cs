using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public interface ICalculadorInss
	{
		/// <summary>
		/// Deve retornar o desconto do INSS aplicado ao salário, na determinada data.
		/// </summary>
		decimal CalcularDesconto(DateTime data, decimal salario);
    }
}
