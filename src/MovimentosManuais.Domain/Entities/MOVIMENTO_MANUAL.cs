using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovimentosManuais.Domain.Entities
{
    public partial class MOVIMENTO_MANUAL
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal DAT_MES { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal DAT_ANO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal NUM_LANCAMENTO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string COD_PRODUTO { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(11)]
        public string COD_COSIF { get; set; }

        [Required]
        [StringLength(50)]
        public string DES_DESCRICAO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DAT_MOVIMENTO { get; set; }

        [Required]
        [StringLength(15)]
        public string COD_USUARIO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VAL_VALOR { get; set; }

        public virtual PRODUTO_COSIF PRODUTO_COSIF { get; set; }
    }
}
