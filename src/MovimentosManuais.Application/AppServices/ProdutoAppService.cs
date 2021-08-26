using AutoMapper;
using MovimentosManuais.Application.Interfaces;
using MovimentosManuais.Application.ViewModels;
using MovimentosManuais.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace MovimentosManuais.Application.AppServices
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoAppService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<ProdutoFormViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<ProdutoFormViewModel>>(_produtoRepository.ObterTodos());
        }
    }
}
