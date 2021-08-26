using MovimentosManuais.Domain.Entities;
using MovimentosManuais.Domain.Interfaces.Repositories;
using MovimentosManuais.Domain.Intrefaces.Services;

namespace MovimentosManuais.Domain.Services
{
    public class MovimentoService : IMovimentoService
    {
        private readonly IMovimentoRepository _movimentoRepository;

        public MovimentoService(IMovimentoRepository movimentoRepository)
        {
            _movimentoRepository = movimentoRepository;
        }

        public MOVIMENTO_MANUAL IncluirMovimento(MOVIMENTO_MANUAL movimento)
        {
            if (!movimento.ValidarMovimento())
                return movimento;

            movimento.AtualizarNumeroDeLancamento(_movimentoRepository);
            movimento.AtualizarDataMovimento();
            movimento.AtualizarCodigoDoUsuario();

            _movimentoRepository.IncluirMovimento(movimento);
            return movimento;
        }
    }
}
