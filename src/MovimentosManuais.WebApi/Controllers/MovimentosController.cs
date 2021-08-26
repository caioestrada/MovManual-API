using MovimentosManuais.Application.Interfaces;
using MovimentosManuais.Application.ViewModels;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MovimentosManuais.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MovimentosController : ApiController
    {
        private readonly IMovimentoAppService _movimentoAppService;

        public MovimentosController(IMovimentoAppService movimnetoAppService)
        {
            _movimentoAppService = movimnetoAppService;
        }

        /// <summary>
        /// Obter todos os movimentos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult ObterTodos()
        {
            try
            {
                var movimentos = _movimentoAppService.ObterTodos();
                if (!movimentos.Any())
                    return BadRequest("Não existem movimentos cadatrados!");

                return Ok(movimentos);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Incluir um novo movimento
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult IncluirMovimento([FromBody] MovimentoManualViewModel movimento)
        {
            try
            {
                var movimentoInserido = _movimentoAppService.IncluirMovimento(movimento);
                if (!movimentoInserido.EhValido)
                    return BadRequest(string.Join(", ", movimentoInserido.Erros));

                return Created(@"/movimentos", movimento);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
