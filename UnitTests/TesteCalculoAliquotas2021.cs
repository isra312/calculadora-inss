using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using INSS;

namespace UnitTestInss
{
    [TestClass]
    public class TesteCalculoAliquotas2021
    {
        [TestMethod]
        public void CalcularAno2021Salario000()
        {
            // Arrange
            DateTime data = new DateTime(2021, 05, 22);
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
        public void CalcularAno2021SalarioNegativo1500()
        {
            // Arrange
            DateTime data = new DateTime(2021, 06, 22);
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
        public void CalcularAno2021Salario1085()
        {
            // Arrange
            DateTime data = new DateTime(2021, 05, 22);
            decimal salario = 1085.00m;
            decimal descontoEsperado = salario * 0.075m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2021Salario1100()
        {
            // Arrange
            DateTime data = new DateTime(2021, 05, 22);
            decimal salario = 1100.00m;
            decimal descontoEsperado = salario * 0.075m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2021Salario1101e01()
        {
            // Arrange
            DateTime data = new DateTime(2021, 05, 22);
            decimal salario = 1101.01m;
            decimal descontoEsperado = salario * 0.09m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }


        [TestMethod]
        public void CalcularAno2021Salario1500()
        {
            // Arrange
            DateTime data = new DateTime(2021, 05, 22);
            decimal salario = 1500.00m;
            decimal descontoEsperado = salario * 0.09m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2021Salario2203e48()
        {
            // Arrange
            DateTime data = new DateTime(2021, 05, 22);
            decimal salario = 2203.48m;
            decimal descontoEsperado = salario * 0.09m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2021Salario2208e49()
        {
            // Arrange
            DateTime data = new DateTime(2021, 05, 22);
            decimal salario = 2208.49m;
            decimal descontoEsperado = salario * 0.12m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2021Salario3000()
        {
            // Arrange
            DateTime data = new DateTime(2021, 05, 22);
            decimal salario = 3000.00m;
            decimal descontoEsperado = salario * 0.12m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2021Salario3305e22()
        {
            // Arrange
            DateTime data = new DateTime(2021, 05, 22);
            decimal salario = 3305.22m;
            decimal descontoEsperado = salario * 0.12m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }


        [TestMethod]
        public void CalcularAno2021Salario3305e23()
        {
            // Arrange
            DateTime data = new DateTime(2021, 05, 22);
            decimal salario = 3305.23m;
            decimal descontoEsperado = salario * 0.14m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2021Salario4000()
        {
            // Arrange
            DateTime data = new DateTime(2021, 05, 22);
            decimal salario = 4000.00m;
            decimal descontoEsperado = salario * 0.14m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2021Salario6433e57()
        {
            // Arrange
            DateTime data = new DateTime(2021, 05, 22);
            decimal salario = 6433.57m;
            decimal descontoEsperado = salario * 0.14m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2021Salario8500()
        {
            // Arrange
            DateTime data = new DateTime(2021, 05, 22);
            decimal salario = 8500.00m;
            decimal descontoEsperado = 751.99m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }


    }
}
