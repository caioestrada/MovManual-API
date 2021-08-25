using MovimentosManuais.Domain.Entities;
using System.Data.Entity;

namespace MovimentosManuais.Infra.Data.EntityMappings
{
    public static class MovimentoManualMapping
    {
        public static void Register(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MOVIMENTO_MANUAL>()
                .Property(e => e.DAT_MES)
                .HasPrecision(2, 0);

            modelBuilder.Entity<MOVIMENTO_MANUAL>()
                .Property(e => e.DAT_ANO)
                .HasPrecision(4, 0);

            modelBuilder.Entity<MOVIMENTO_MANUAL>()
                .Property(e => e.NUM_LANCAMENTO)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MOVIMENTO_MANUAL>()
                .Property(e => e.COD_PRODUTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOVIMENTO_MANUAL>()
                .Property(e => e.COD_COSIF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOVIMENTO_MANUAL>()
                .Property(e => e.DES_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<MOVIMENTO_MANUAL>()
                .Property(e => e.COD_USUARIO)
                .IsUnicode(false);
        }
    }
}
