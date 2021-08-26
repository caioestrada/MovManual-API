using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovimentosManuais.Domain.Entities;
using System;

namespace MovimentosManuais.Domain.UnitTest.Entities
{
    [TestClass]
    public class MovimentoManualTest
    {
        [TestMethod]
        public void ValidarMovimentoComSucesso()
        {
            // Arrange
            var movimento = new MOVIMENTO_MANUAL
            {
                DAT_MES = 2,
                DAT_ANO = 2019,
                NUM_LANCAMENTO = 1,
                COD_PRODUTO = "001",
                COD_COSIF = "30000001",
                DES_DESCRICAO = "TEST DESC",
                DAT_MOVIMENTO = DateTime.Now,
                COD_USUARIO = "TESTE",
                VAL_VALOR = 150
            };

            // Act
            movimento.ValidarMovimento();

            // Assert
            Assert.IsTrue(movimento.EhValido);
        }

        [TestMethod]
        public void ValidarMovimentoComErro()
        {
            // Arrange
            var movimento = new MOVIMENTO_MANUAL
            {
                DAT_MES = 0,
                DAT_ANO = 0,
                NUM_LANCAMENTO = 1,
                COD_PRODUTO = "001",
                COD_COSIF = "30000001",
                DES_DESCRICAO = "TEST DESC",
                DAT_MOVIMENTO = DateTime.Now,
                COD_USUARIO = "TESTE",
                VAL_VALOR = 150
            };

            // Act
            movimento.ValidarMovimento();

            // Assert
            Assert.IsFalse(movimento.EhValido);
            Assert.AreEqual(2, movimento.Erros.Count);
        }

        [TestMethod]
        public void AtualizarDataMovimentoComSucesso()
        {
            // Arrange
            var movimento = new MOVIMENTO_MANUAL
            {
                DAT_MES = 2,
                DAT_ANO = 2019,
                NUM_LANCAMENTO = 1,
                COD_PRODUTO = "001",
                COD_COSIF = "30000001",
                DES_DESCRICAO = "TEST DESC",
                DAT_MOVIMENTO = DateTime.Now.AddDays(10),
                COD_USUARIO = "TESTE",
                VAL_VALOR = 150
            };

            // Act
            movimento.AtualizarDataMovimento();

            // Assert
            Assert.AreEqual(DateTime.Now.Date, movimento.DAT_MOVIMENTO.Date);
        }

        [TestMethod]
        public void AtualizarCodigoDoUsuarioComSucesso()
        {
            // Arrange
            var movimento = new MOVIMENTO_MANUAL
            {
                DAT_MES = 2,
                DAT_ANO = 2019,
                NUM_LANCAMENTO = 1,
                COD_PRODUTO = "001",
                COD_COSIF = "30000001",
                DES_DESCRICAO = "TEST DESC",
                DAT_MOVIMENTO = DateTime.Now.AddDays(10),
                COD_USUARIO = "",
                VAL_VALOR = 150
            };

            // Act
            movimento.AtualizarCodigoDoUsuario();

            // Assert
            Assert.AreEqual("TESTE", movimento.COD_USUARIO);
        }
    }
}
