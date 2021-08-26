using MovimentosManuais.Application.ViewModels;
using System.Collections.Generic;

namespace MovimentosManuais.WebApi.UnitTest.MockModels
{
    public static class ProdutoMockModel
    {
        public static List<ProdutoFormViewModel> ObterProdutos()
        {
            return new List<ProdutoFormViewModel>
            {
                new ProdutoFormViewModel
                {
                    Codigo = "001",
                    Descricao = "DESC 001",
                    Status = "A"
                },
                new ProdutoFormViewModel
                {
                    Codigo = "002",
                    Descricao = "DESC 002",
                    Status = "A",
                }
            };
        }
    }
}
