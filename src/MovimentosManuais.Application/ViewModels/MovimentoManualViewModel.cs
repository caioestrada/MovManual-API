using System;
using System.ComponentModel.DataAnnotations;

namespace MovimentosManuais.Application.ViewModels
{
    public class MovimentoManualViewModel : EntityViewModel
    {
        [Required]
        public decimal Mes { get; set; }

        [Required]
        public decimal Ano { get; set; }

        public decimal NumeroLancamento { get; set; }

        [Required]
        public string CodigoProduto { get; set; }

        [Required]
        public string CodigoCosif { get; set; }

        [Required]
        public string Descricao { get; set; }

        public DateTime DataMovimento { get; set; }

        public string CodigoUsuario { get; set; }

        [Required]
        public decimal Valor { get; set; }

        public ProdutoCosifViewModel ProdutoCosif { get; set; }
    }
}
