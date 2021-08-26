using MovimentosManuais.Application.AppServices;
using MovimentosManuais.Application.Interfaces;
using MovimentosManuais.Domain.Interfaces.Repositories;
using MovimentosManuais.Domain.Intrefaces.Services;
using MovimentosManuais.Domain.Services;
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
            container.Register<IMovimentoAppService, MovimentoAppService>(Lifestyle.Scoped);
            container.Register<IProdutoAppService, ProdutoAppService>(Lifestyle.Scoped);

            // Domain
            container.Register<IMovimentoService, MovimentoService>(Lifestyle.Scoped);

            // Data
            container.Register<IMovimentoRepository, MovimentoRepository>(Lifestyle.Scoped);
            container.Register<IProdutoRepository, ProdutoRepository>(Lifestyle.Scoped);

            // Context
            container.Register<MovimentoContext>(Lifestyle.Scoped);
        }
    }
}
