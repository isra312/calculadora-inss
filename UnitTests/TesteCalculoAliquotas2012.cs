using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using INSS;

namespace UnitTestInss
{
    [TestClass]
    public class TesteCalculoAliquotas2012
    {
        [TestMethod]
        public void CalcularAno2012Salario000()
        {
            // Arrange
            DateTime data = new DateTime(2012, 05, 22);
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
        public void CalcularAno2012SalarioNegativo1500()
        {
            // Arrange
            DateTime data = new DateTime(2012, 06, 22);
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
        public void CalcularAno2012Salario0985()
        {
            // Arrange
            DateTime data = new DateTime(2012, 05, 22);
            decimal salario = 985.00m;
            decimal descontoEsperado = salario * 0.07m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2012Salario1000()
        {
            // Arrange
            DateTime data = new DateTime(2012, 05, 22);
            decimal salario = 1000.00m;
            decimal descontoEsperado = salario * 0.07m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2012Salario1000e01()
        {
            // Arrange
            DateTime data = new DateTime(2012, 05, 22);
            decimal salario = 1000.01m;
            decimal descontoEsperado = salario * 0.08m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2012Salario1301e11()
        {
            // Arrange
            DateTime data = new DateTime(2012, 05, 22);
            decimal salario = 1301.11m;
            decimal descontoEsperado = salario * 0.08m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }


        [TestMethod]
        public void CalcularAno2012Salario1500()
        {
            // Arrange
            DateTime data = new DateTime(2012, 05, 22);
            decimal salario = 1500.00m;
            decimal descontoEsperado = salario * 0.08m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2012Salario1500e01()
        {
            // Arrange
            DateTime data = new DateTime(2012, 05, 22);
            decimal salario = 1500.01m;
            decimal descontoEsperado = salario * 0.09m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2012Salario2472e19()
        {
            // Arrange
            DateTime data = new DateTime(2012, 05, 22);
            decimal salario = 2472.19m;
            decimal descontoEsperado = salario * 0.09m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2012Salario3000()
        {
            // Arrange
            DateTime data = new DateTime(2012, 05, 22);
            decimal salario = 3000.00m;
            decimal descontoEsperado = salario * 0.09m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2012Salario3000e01()
        {
            // Arrange
            DateTime data = new DateTime(2012, 05, 22);
            decimal salario = 3000.01m;
            decimal descontoEsperado = salario * 0.11m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }


        [TestMethod]
        public void CalcularAno2012Salario3581e48()
        {
            // Arrange
            DateTime data = new DateTime(2012, 05, 22);
            decimal salario = 3581.48m;
            decimal descontoEsperado = salario * 0.11m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }

        [TestMethod]
        public void CalcularAno2012Salario4000()
        {
            // Arrange
            DateTime data = new DateTime(2012, 05, 22);
            decimal salario = 4000.00m;
            decimal descontoEsperado = salario * 0.11m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }


        [TestMethod]
        public void CalcularAno2012Salario4500()
        {
            // Arrange
            DateTime data = new DateTime(2012, 05, 22);
            decimal salario = 4500.00m;
            decimal descontoEsperado = 500.00m;

            TabelaAno tabela = new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);
            CalculadoraInss calculadora = new CalculadoraInss(tabela);

            // Act
            var desconto = calculadora.CalcularDesconto(data, salario);

            // Assert
            Assert.AreEqual(descontoEsperado, desconto);
        }


    }
}
