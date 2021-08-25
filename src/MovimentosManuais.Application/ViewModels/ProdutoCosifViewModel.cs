using System.Collections.Generic;

namespace MovimentosManuais.Application.ViewModels
{
    public class ProdutoCosifViewModel
    {
        public string CodigoProduto { get; set; }
        public string CodigoCosif { get; set; }
        public string CodigoClassificacao { get; set; }
        public string Status { get; set; }
        public IEnumerable<MovimentoManualViewModel> MovimentosManuais { get; set; }
    }
}
