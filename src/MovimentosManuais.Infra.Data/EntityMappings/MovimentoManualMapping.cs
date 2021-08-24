using MovimentosManuais.Infra.Data.Entities;
using System.Data.Entity;

namespace MovimentosManuais.Infra.Data.EntityMappings
{
    public static class MovimentoManualMapping
    {
        public static void Register(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovimentoManual>()
                .Property(e => e.DAT_MES)
                .HasPrecision(2, 0);

            modelBuilder.Entity<MovimentoManual>()
                .Property(e => e.DAT_ANO)
                .HasPrecision(4, 0);

            modelBuilder.Entity<MovimentoManual>()
                .Property(e => e.NUM_LANCAMENTO)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MovimentoManual>()
                .Property(e => e.COD_PRODUTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MovimentoManual>()
                .Property(e => e.COD_COSIF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MovimentoManual>()
                .Property(e => e.DES_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<MovimentoManual>()
                .Property(e => e.COD_USUARIO)
                .IsUnicode(false);
        }
    }
}
