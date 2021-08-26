using MovimentosManuais.Domain.Interfaces.Repositories;
using MovimentosManuais.Domain.Validations.Movimento;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MovimentosManuais.Domain.Entities
{
    public partial class MOVIMENTO_MANUAL : Entity
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal DAT_MES { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal DAT_ANO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal NUM_LANCAMENTO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string COD_PRODUTO { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(11)]
        public string COD_COSIF { get; set; }

        [Required]
        [StringLength(50)]
        public string DES_DESCRICAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DAT_MOVIMENTO { get; set; }

        [Required]
        [StringLength(15)]
        public string COD_USUARIO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VAL_VALOR { get; set; }

        public virtual PRODUTO_COSIF PRODUTO_COSIF { get; set; }

        public bool ValidarMovimento()
        {
            var validacao = new IncluirMovimentoValidation().Validate(this);
            this.EhValido = validacao.IsValid;
            this.Erros = validacao.Errors.Select(err => err.ErrorMessage).ToList();

            return EhValido;
        }

        public void AtualizarNumeroDeLancamento(IMovimentoRepository movimentoRepository)
        {
            var ultimoLancamentoMesAno = movimentoRepository.ObterUltimoLancamentoPorMesAno(this.DAT_MES, this.DAT_ANO);
            if (ultimoLancamentoMesAno == null)
            {
                this.NUM_LANCAMENTO = 1;
                return;
            }

            this.NUM_LANCAMENTO = ultimoLancamentoMesAno.NUM_LANCAMENTO + 1;
        }

        public void AtualizarDataMovimento() => this.DAT_MOVIMENTO = DateTime.Now;

        public void AtualizarCodigoDoUsuario() => this.COD_USUARIO = "TESTE";

    }
}
