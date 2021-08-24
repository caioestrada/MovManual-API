using MovimentosManuais.Infra.Data.Context;
using MovimentosManuais.Infra.Data.Entities;
using MovimentosManuais.Infra.Data.Interfaces;
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

        public IEnumerable<Produto> ObterTodos()
        {
            return _movimentoContext.Produtos;
        }
    }
}
