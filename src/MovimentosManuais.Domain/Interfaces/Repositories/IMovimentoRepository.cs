using MovimentosManuais.Domain.Entities;
using System.Collections.Generic;

namespace MovimentosManuais.Domain.Interfaces.Repositories
{
    public interface IMovimentoRepository
    {
        IEnumerable<MOVIMENTO_MANUAL> ObterTodos();
        MOVIMENTO_MANUAL ObterUltimoLancamentoPorMesAno(decimal mes, decimal ano);
        bool IncluirMovimento(MOVIMENTO_MANUAL movimento);
    }
}
