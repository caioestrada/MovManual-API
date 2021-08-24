using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovimentosManuais.Infra.Data.Entities
{
    [Table("PRODUTO")]
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            PRODUTO_COSIF = new HashSet<ProdutoCosif>();
        }

        [Key]
        [StringLength(4)]
        public string COD_PRODUTO { get; set; }

        [StringLength(30)]
        public string DES_PRODUTO { get; set; }

        [StringLength(1)]
        public string STA_STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoCosif> PRODUTO_COSIF { get; set; }
    }
}
