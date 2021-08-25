using System.Collections.Generic;

namespace MovimentosManuais.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public IEnumerable<ProdutoCosifViewModel> ProdutosCosif { get; set; }
    }
}
