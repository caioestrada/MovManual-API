using System.Collections.Generic;

namespace MovimentosManuais.Application.ViewModels
{
    public class ProdutoFormViewModel
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public IEnumerable<ProdutoCosifFormViewModel> ProdutosCosif { get; set; }
    }
}
