using MovimentosManuais.Application.ViewModels;
using System.Collections.Generic;

namespace MovimentosManuais.Application.Interfaces
{
    public interface IProdutoAppService
    {
        IEnumerable<ProdutoViewModel> ObterTodos();
    }
}
