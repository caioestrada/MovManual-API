using MovimentosManuais.Domain.Entities;
using MovimentosManuais.Domain.Interfaces.Repositories;
using MovimentosManuais.Infra.Data.Context;
using System.Collections.Generic;

namespace MovimentosManuais.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MovimentoContext _movimentoContext;

        public ProdutoRepository(MovimentoContext movimentoContext)
        {
            _movimentoContext = movimentoContext;
        }

        public IEnumerable<PRODUTO> ObterTodos()
        {
            return _movimentoContext.PRODUTO
                .Include("PRODUTO_COSIF");
        }
    }
}
