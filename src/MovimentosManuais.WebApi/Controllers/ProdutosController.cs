using MovimentosManuais.Application.Interfaces;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MovimentosManuais.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProdutosController : ApiController
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutosController(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        /// <summary>
        /// Rota para obter todos os produtos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult ObterTodos()
        {
            var produtos = _produtoAppService.ObterTodos();
            if (!produtos.Any())
                return BadRequest("Não existem produtos cadatrados!");

            return Ok(produtos);
        }
    }
}
