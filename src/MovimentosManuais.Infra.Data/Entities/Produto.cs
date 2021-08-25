using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovimentosManuais.Infra.Data.Entities
{
    [Table("PRODUTO")]
    public partial class PRODUTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUTO()
        {
            PRODUTO_COSIF = new HashSet<PRODUTO_COSIF>();
        }

        [Key]
        [StringLength(4)]
        public string COD_PRODUTO { get; set; }

        [StringLength(30)]
        public string DES_PRODUTO { get; set; }

        [StringLength(1)]
        public string STA_STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_COSIF> PRODUTO_COSIF { get; set; }
    }
}
