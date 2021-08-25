using MovimentosManuais.Domain.Entities;
using MovimentosManuais.Infra.Data.EntityMappings;
using System.Data.Entity;

namespace MovimentosManuais.Infra.Data.Context
{
    public partial class MovimentoContext : DbContext
    {
        public virtual DbSet<MOVIMENTO_MANUAL> MOVIMENTO_MANUAL { get; set; }
        public virtual DbSet<PRODUTO> PRODUTO { get; set; }
        public virtual DbSet<PRODUTO_COSIF> PRODUTO_COSIF { get; set; }

        public MovimentoContext() : base("name=MovimentoContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            MovimentoManualMapping.Register(modelBuilder);
            ProdutoMapping.Register(modelBuilder);
            ProdutoCosifMapping.Register(modelBuilder);
        }
    }
}
