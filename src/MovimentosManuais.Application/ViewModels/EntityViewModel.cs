using System.Collections.Generic;

namespace MovimentosManuais.Application.ViewModels
{
    public class EntityViewModel
    {
        public bool EhValido { get; set; }
        public List<string> Erros { get; set; }
    }
}
