using System;

namespace MovimentosManuais.Application.ViewModels
{
    public class MovimentoManualViewModel
    {
        public decimal Mes { get; set; }
        public decimal Ano { get; set; }
        public decimal NumeroLancamento { get; set; }
        public string CodigoProduto { get; set; }
        public string CodigoCosif { get; set; }
        public string Descricao { get; set; }
        public DateTime DataMovimento { get; set; }
        public string CodigoUsuario { get; set; }
        public decimal Valor { get; set; }
    }
}
