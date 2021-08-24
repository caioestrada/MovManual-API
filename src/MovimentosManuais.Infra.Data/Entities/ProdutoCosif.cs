using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovimentosManuais.Infra.Data.Entities
{
    [Table("PRODUTO_COSIF")]
    public partial class ProdutoCosif
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProdutoCosif()
        {
            MOVIMENTO_MANUAL = new HashSet<MovimentoManual>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string COD_PRODUTO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(11)]
        public string COD_COSIF { get; set; }

        [StringLength(6)]
        public string COD_CLASSIFICACAO { get; set; }

        [StringLength(1)]
        public string STA_STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovimentoManual> MOVIMENTO_MANUAL { get; set; }

        public virtual Produto PRODUTO { get; set; }
    }
}
