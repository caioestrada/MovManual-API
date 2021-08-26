using MovimentosManuais.Application.ViewModels;
using System.Collections.Generic;

namespace MovimentosManuais.Application.Interfaces
{
    public interface IMovimentoAppService
    {
        IEnumerable<MovimentoManualViewModel> ObterTodos();
        MovimentoManualViewModel IncluirMovimento(MovimentoManualViewModel movimento);
    }
}
