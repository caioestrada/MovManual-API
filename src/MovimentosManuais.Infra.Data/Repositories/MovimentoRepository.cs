using MovimentosManuais.Domain.Entities;
using MovimentosManuais.Domain.Interfaces.Repositories;
using MovimentosManuais.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace MovimentosManuais.Infra.Data.Repositories
{
    public class MovimentoRepository : IMovimentoRepository
    {
        private readonly MovimentoContext _movimentoContext;

        public MovimentoRepository(MovimentoContext movimentoContext)
        {
            _movimentoContext = movimentoContext;
        }

        public IEnumerable<MOVIMENTO_MANUAL> ObterTodos()
        {
            return _movimentoContext.MOVIMENTO_MANUAL
                .Include("PRODUTO_COSIF.PRODUTO");
        }

        public MOVIMENTO_MANUAL ObterUltimoLancamentoPorMesAno(decimal mes, decimal ano)
        {
            var movimentosDoMesAno =_movimentoContext.MOVIMENTO_MANUAL
                .Where(mov => mov.DAT_MES == mes && mov.DAT_ANO == ano);

            return movimentosDoMesAno.OrderByDescending(mov => mov.NUM_LANCAMENTO).FirstOrDefault();
        }

        public bool IncluirMovimento(MOVIMENTO_MANUAL movimento)
        {
            _movimentoContext.MOVIMENTO_MANUAL.Add(movimento);
            var adicionado = _movimentoContext.SaveChanges();

            return adicionado > 0;
        }
    }
}
