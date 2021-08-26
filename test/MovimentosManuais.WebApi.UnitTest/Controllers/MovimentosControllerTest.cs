using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MovimentosManuais.Application.Interfaces;
using MovimentosManuais.Application.ViewModels;
using MovimentosManuais.WebApi.Controllers;
using MovimentosManuais.WebApi.UnitTest.MockModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;

namespace MovimentosManuais.WebApi.UnitTest.Controllers
{
    [TestClass]
    public class MovimentosControllerTest
    {
        [TestMethod]
        public void ObterTodosComSucesso()
        {
            // Arrange
            var movimentoAppService = new Mock<IMovimentoAppService>();
            movimentoAppService.Setup(mock => mock.ObterTodos()).Returns(MovimentoMockModel.ObterMovimentos());

            // Act
            var movimentosController = new MovimentosController(movimentoAppService.Object);
            var resultadoObterTodos = movimentosController.ObterTodos() as OkNegotiatedContentResult<IEnumerable<MovimentoManualViewModel>>;

            // Assert
            Assert.AreEqual(2, resultadoObterTodos.Content.Count());
        }

        [TestMethod]
        public void ObterTodosVazio()
        {
            // Arrange
            var movimentoAppService = new Mock<IMovimentoAppService>();
            movimentoAppService.Setup(mock => mock.ObterTodos()).Returns(new List<MovimentoManualViewModel>(0));

            // Act
            var movimentosController = new MovimentosController(movimentoAppService.Object);
            var resultadoObterTodos = movimentosController.ObterTodos() as BadRequestErrorMessageResult;

            // Assert
            Assert.AreEqual("Não existem movimentos cadatrados!", resultadoObterTodos.Message);
        }

        [TestMethod]
        public void IncluirComSucesso()
        {
            // Arrange
            var movimentoAppService = new Mock<IMovimentoAppService>();
            var movimento = MovimentoMockModel.ObterMovimentoCorretoParaInclusao();
            movimentoAppService.Setup(mock => mock.IncluirMovimento(movimento)).Returns(movimento);

            // Act
            var movimentosController = new MovimentosController(movimentoAppService.Object);
            var resultadoIncluir = movimentosController.IncluirMovimento(movimento) as CreatedNegotiatedContentResult<MovimentoManualViewModel>;

            // Assert
            Assert.AreEqual(2, resultadoIncluir.Content.Mes);
            Assert.AreEqual(2019, resultadoIncluir.Content.Ano);
            Assert.AreEqual("001", resultadoIncluir.Content.CodigoProduto);
        }

        [TestMethod]
        public void IncluirComErro()
        {
            // Arrange
            var movimentoAppService = new Mock<IMovimentoAppService>();
            var movimento = MovimentoMockModel.ObterMovimentoComErroParaInclusao();
            movimentoAppService.Setup(mock => mock.IncluirMovimento(movimento)).Returns(movimento);

            // Act
            var movimentosController = new MovimentosController(movimentoAppService.Object);
            var resultadoIncluir = movimentosController.IncluirMovimento(movimento) as BadRequestErrorMessageResult;

            // Assert
            Assert.IsNotNull(resultadoIncluir.Message);
        }
    }
}
