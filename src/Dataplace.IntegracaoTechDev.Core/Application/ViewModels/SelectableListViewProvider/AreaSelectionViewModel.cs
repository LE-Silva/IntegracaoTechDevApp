using Dataplace.Core.Application.ViewModels.Contracts;
using System;

namespace Dataplace.IntegracaoTechDev.Core.Application.ViewModels.SelectableListViewProvider
{
    public class AreaSelectionViewModel : ISelectableViewModel, IEquatable<AreaSelectionViewModel>
    {
        public string CdArea { get; set; }
        public string Descricao { get; set; }

        public bool IsSelected { get; set; }

        public bool Equals(AreaSelectionViewModel other)
        {
            return CdArea == other.CdArea;
        }
    }
}
