using Dataplace.IntegracaoTechDev.Core.Application.Queries.Cupom;
using Dataplace.IntegracaoTechDev.Core.Application.ViewModels;
using dpLibrary05.Infrastructure.ServiceLocator;
using MediatR;
using System.Collections.Generic;

namespace Dataplace.IntegracaoTechDev.Core.Infra.CrossCutting.IoC
{
    public static class BootStrapper
    {
        public static Container Container;
        public static void Bootstrap(Container container)
        {
            BootStrapper.Container = container;

            RegisterCupom(container);
        }

        private static void RegisterCupom(Container container)
        {
            container.Register<IRequestHandler<ConsultaCupomFilter, IEnumerable<ConsultaCupomViewModel>>, CupomQueryHandler>();
        }
    }
}
