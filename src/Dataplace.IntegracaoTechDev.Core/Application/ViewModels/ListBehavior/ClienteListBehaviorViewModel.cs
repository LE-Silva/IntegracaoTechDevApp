using Dataplace.Core.Application.Contracts.Results;
using Dataplace.Core.Application.ViewModels.Contracts;
using System;

namespace Dataplace.IntegracaoTechDev.Core.Application.ViewModels.ListBehavior
{
    public class ClienteListBehaviorViewModel :  ISelectableViewModel, IResultViewModel, IEquatable<ClienteListBehaviorViewModel>
    {
        private IResult _result;

        public bool IsSelected { get; set; }
        public IResult Result { get => _result; set => _result = value; }
        public string CdCliente { get; set; }
        public string Razao { get; set; }
        public string Fantasia { get; set; }

        public bool Equals(ClienteListBehaviorViewModel other)
        {
            if (other == null)
                return false;

            return this.CdCliente.Equals(other.CdCliente);
        }
    }
}
