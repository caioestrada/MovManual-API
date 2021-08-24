using MovimentosManuais.Infra.Data.Entities;
using System.Data.Entity;

namespace MovimentosManuais.Infra.Data.EntityMappings
{
    public static class ProdutoMapping
    {
        public static void Register(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(e => e.COD_PRODUTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.DES_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.STA_STATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.PRODUTO_COSIF)
                .WithRequired(e => e.PRODUTO)
                .WillCascadeOnDelete(false);
        }
    }
}
