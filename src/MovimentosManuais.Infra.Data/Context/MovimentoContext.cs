using MovimentosManuais.Infra.Data.Entities;
using MovimentosManuais.Infra.Data.EntityMappings;
using System.Data.Entity;

namespace MovimentosManuais.Infra.Data.Context
{
    public partial class MovimentoContext : DbContext
    {
        public MovimentoContext()
            : base("name=MovimentoContext")
        {
        }

        public virtual DbSet<MovimentoManual> MovimentosManuais { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<ProdutoCosif> ProdutosCosif { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            MovimentoManualMapping.Register(modelBuilder);
            ProdutoMapping.Register(modelBuilder);
            ProdutoCosifMapping.Register(modelBuilder);
        }
    }
}
