using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using INSS;

namespace UnitTestInss
{
    [TestClass]
    public class TesteCalculoAliquotas2011
    {
        [TestMethod]
        public void CalcularAno2011Salario000()
        {
            // Arrange
            DateTime data = new DateTime(2011, 05, 22);
            decimal salario = 0.00m;
            decimal descontoEsperado = 0.00m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2011SalarioNegativo1500()
        {
            // Arrange
            DateTime data = new DateTime(2011, 05, 22);
            decimal salario = -1500.00m;
            decimal descontoEsperado = 0.00m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2011Salario1000()
        {
            // Arrange
            DateTime data = new DateTime(2011, 05, 22);
            decimal salario = 1000.00m;
            decimal descontoEsperado = salario * 0.08m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2011Salario1106e90()
        {
            // Arrange
            DateTime data = new DateTime(2011, 05, 22);
            decimal salario = 1106.90m;
            decimal descontoEsperado = salario * 0.08m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year); 
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2011Salario1106e91()
        {
            // Arrange
            DateTime data = new DateTime(2011, 05, 22);
            decimal salario = 1106.91m;
            decimal descontoEsperado = salario * 0.09m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2011Salario1408e53()
        {
            // Arrange
            DateTime data = new DateTime(2011, 05, 22);
            decimal salario = 1408.53m;
            decimal descontoEsperado = salario * 0.09m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2011Salario1844e83()
        {
            // Arrange
            DateTime data = new DateTime(2011, 05, 22);
            decimal salario = 1844.83m;
            decimal descontoEsperado = salario * 0.09m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2011Salario1844e84()
        {
            // Arrange
            DateTime data = new DateTime(2011, 05, 22);
            decimal salario = 1844.84m;
            decimal descontoEsperado = salario * 0.11m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2011Salario2456e72()
        {
            // Arrange
            DateTime data = new DateTime(2011, 05, 22);
            decimal salario = 2456.72m;
            decimal descontoEsperado = salario * 0.11m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }


        [TestMethod]
        public void CalcularAno2011Salario3689e66()
        {
            // Arrange
            DateTime data = new DateTime(2011, 05, 22);
            decimal salario = 3689.66m;
            decimal descontoEsperado = salario * 0.11m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2011Salario3700()
        {
            // Arrange
            DateTime data = new DateTime(2011, 05, 22);
            decimal salario = 3700.00m;
            decimal descontoEsperado = 405.86m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

    }
}
