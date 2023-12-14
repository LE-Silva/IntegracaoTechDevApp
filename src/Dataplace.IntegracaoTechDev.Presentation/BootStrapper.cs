using Dataplace.Core.win.Views.Extensions;
using Dataplace.Core.win.Views;
using Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.SelectableListViewProvider.Providers;
using dpLibrary05.Infrastructure.ServiceLocator;

namespace Dataplace.IntegracaoTechDev.Presentation
{
    public static class BootStrapper
    {
        public static Container Container;

        public static void Bootstrap(Container container)
        {
            BootStrapper.Container = container;

            Dataplace.IntegracaoTechDev.Core.Infra.CrossCutting.IoC.BootStrapper.Bootstrap(container);

            RegisterViewProviders(container);
        }

        private static void RegisterViewProviders(Container container)
        {
            container.RegisterViewProvider<SelectableListView, AreaSelectionListViewProvider>();
        }
    }
}
