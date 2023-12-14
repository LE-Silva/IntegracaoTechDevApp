using Dataplace.Core.Comunications;
using Dataplace.Core.Domain.Entities;
using Dataplace.Core.Domain.Localization.Messages.Extensions;
using Dataplace.Core.win.Controls.List.Configurations;
using Dataplace.Core.win.Views.Providers.Contracts;
using Dataplace.Core.win.Views.Providers;
using System.Collections.Generic;
using Dataplace.IntegracaoTechDev.Core.Application.ViewModels.SelectableListViewProvider;

namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.SelectableListViewProvider.Providers
{
    public class AreaSelectionListViewProvider : SelectableListViewProvider<AreaSelectionViewModel, AreaSelectionFilterViewModel>, ISelectableListViewProvider<AreaSelectionViewModel, AreaSelectionFilterViewModel>
    {
        public override void Configure(ViewModelListBuilder<AreaSelectionViewModel> builder)
        {
            builder.View.Caption = 6355.ToMessage();

            builder.Property(x => x.CdArea).HasCaption(143.ToMessage());
            builder.Property(x => x.Descricao).HasCaption(2802.ToMessage());
        }

        public override IEnumerable<AreaSelectionViewModel> GetDatasource(AreaSelectionFilterViewModel filter, IEnumerable<SortDescriptor> sortings)
        {
            using (var scope = dpLibrary05.Infrastructure.ServiceLocator.ServiceLocatorScoped.Factory())
            {
                var mediator = scope.Container.GetInstance<IMediatorHandler>();
                return mediator.Query(filter).Result;
            }
        }

    }
}
