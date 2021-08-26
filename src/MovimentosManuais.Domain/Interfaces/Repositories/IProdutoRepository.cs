using MovimentosManuais.Domain.Entities;
using System.Collections.Generic;

namespace MovimentosManuais.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<PRODUTO> ObterTodos();
    }
}
