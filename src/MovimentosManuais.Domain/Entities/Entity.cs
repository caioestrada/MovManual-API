using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovimentosManuais.Domain.Entities
{
    public class Entity
    {
        [NotMapped]
        public bool EhValido { get; set; }

        [NotMapped]
        public List<string> Erros { get; set; }
    }
}
