using MovimentosManuais.Application.AppServices;
using MovimentosManuais.Application.Interfaces;
using MovimentosManuais.Domain.Interfaces.Repositories;
using MovimentosManuais.Infra.Data.Context;
using MovimentosManuais.Infra.Data.Repositories;
using SimpleInjector;

namespace MovimentosManuais.Infra.Crosscutting.IoC
{
    public class BootStrapper
    {
        public static void Register(Container container)
        {
            // App
            container.Register<IProdutoAppService, ProdutoAppService>(Lifestyle.Scoped);

            // Data
            container.Register<IProdutoRepository, ProdutoRepository>(Lifestyle.Scoped);

            // Context
            container.Register<MovimentoContext>(Lifestyle.Scoped);

            // Unit of Work
            //container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
        }
    }
}
