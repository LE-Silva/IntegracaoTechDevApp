using Dataplace.Core.Domain.Query;
using System.Collections.Generic;

namespace Dataplace.IntegracaoTechDev.Core.Application.ViewModels.SelectableListViewProvider
{
    public class AreaSelectionFilterViewModel : QuerySort<IEnumerable<AreaSelectionViewModel>>, IQuerySort<IEnumerable<AreaSelectionViewModel>>
    {
        public string CdEmpresa { get; set; }
        public string CdFilial { get; set; }
        public string CdArea { get; set; }
        public string Descricao { get; set; }
    }
}
