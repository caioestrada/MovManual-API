using MovimentosManuais.Infra.Data.Entities;
using System.Data.Entity;

namespace MovimentosManuais.Infra.Data.EntityMappings
{
    public static class ProdutoCosifMapping
    {
        public static void Register(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PRODUTO_COSIF>()
                .Property(e => e.COD_PRODUTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_COSIF>()
                .Property(e => e.COD_COSIF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_COSIF>()
                .Property(e => e.COD_CLASSIFICACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_COSIF>()
                .Property(e => e.STA_STATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_COSIF>()
                .HasMany(e => e.MOVIMENTO_MANUAL)
                .WithRequired(e => e.PRODUTO_COSIF)
                .HasForeignKey(e => new { e.COD_PRODUTO, e.COD_COSIF })
                .WillCascadeOnDelete(false);
        }
    }
}
