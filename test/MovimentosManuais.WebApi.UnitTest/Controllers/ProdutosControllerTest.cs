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
    public class ProdutosControllerTest
    {
        [TestMethod]
        public void ObterTodosComSucesso()
        {
            // Arrange
            var produtoAppService = new Mock<IProdutoAppService>();
            produtoAppService.Setup(mock => mock.ObterTodos()).Returns(ProdutoMockModel.ObterProdutos());

            // Act
            var produtosController = new ProdutosController(produtoAppService.Object);
            var resultadoObterTodos = produtosController.ObterTodos() as OkNegotiatedContentResult<IEnumerable<ProdutoFormViewModel>>;

            // Assert
            Assert.AreEqual(2, resultadoObterTodos.Content.Count());
        }

        [TestMethod]
        public void ObterTodosVazio()
        {
            // Arrange
            var produtoAppService = new Mock<IProdutoAppService>();
            produtoAppService.Setup(mock => mock.ObterTodos()).Returns(new List<ProdutoFormViewModel>(0));

            // Act
            var produtosController = new ProdutosController(produtoAppService.Object);
            var resultadoObterTodos = produtosController.ObterTodos() as BadRequestErrorMessageResult;

            // Assert
            Assert.AreEqual("Não existem produtos cadatrados!", resultadoObterTodos.Message);
        }
    }
}
