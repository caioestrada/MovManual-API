using MovimentosManuais.Domain.Entities;
using System.Collections.Generic;

namespace MovimentosManuais.Domain.Intrefaces.Services
{
    public interface IMovimentoService
    {
        MOVIMENTO_MANUAL IncluirMovimento(MOVIMENTO_MANUAL movimento);
    }
}
