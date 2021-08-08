using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using INSS;

namespace UnitTestInss
{
    [TestClass]
    public class TesteExcecoes
    {
        [TestMethod]
        public void TesteAnoInexistente()
        {
            // Arrange
            DateTime data = new DateTime(2020, 05, 22);

            // Act
            Action actual = () => new TabelaRepositorioDummy().CarregarTabelaInss(data.Year);

            // Assert
            Assert.ThrowsException<ArgumentNullException>(actual);
        }
    }
}
