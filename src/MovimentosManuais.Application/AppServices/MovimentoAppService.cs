using AutoMapper;
using MovimentosManuais.Application.Interfaces;
using MovimentosManuais.Application.ViewModels;
using MovimentosManuais.Domain.Entities;
using MovimentosManuais.Domain.Interfaces.Repositories;
using MovimentosManuais.Domain.Intrefaces.Services;
using System.Collections.Generic;

namespace MovimentosManuais.Application.AppServices
{
    public class MovimentoAppService : IMovimentoAppService
    {
        private readonly IMovimentoService _movimentoService;
        private readonly IMovimentoRepository _movimentoRepository;

        public MovimentoAppService(IMovimentoRepository produtoRepository, IMovimentoService movimentoService)
        {
            _movimentoService = movimentoService;
            _movimentoRepository = produtoRepository;
        }

        public IEnumerable<MovimentoManualViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<MovimentoManualViewModel>>(_movimentoRepository.ObterTodos());
        }

        public MovimentoManualViewModel IncluirMovimento(MovimentoManualViewModel movimento)
        {
            var movimentoEntity = Mapper.Map<MOVIMENTO_MANUAL>(movimento);
            return Mapper.Map<MovimentoManualViewModel>(_movimentoService.IncluirMovimento(movimentoEntity));
        }
    }
}
