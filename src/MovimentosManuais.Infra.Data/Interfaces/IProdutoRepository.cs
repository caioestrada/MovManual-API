using MovimentosManuais.Infra.Data.Entities;
using System.Collections.Generic;

namespace MovimentosManuais.Infra.Data.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> ObterTodos();
    }
}
