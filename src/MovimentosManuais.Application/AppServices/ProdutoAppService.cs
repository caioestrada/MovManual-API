using AutoMapper;
using MovimentosManuais.Application.Interfaces;
using MovimentosManuais.Application.ViewModels;
using MovimentosManuais.Infra.Data.Interfaces;
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

        public IEnumerable<ProdutoViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoRepository.ObterTodos());
        }
    }
}
