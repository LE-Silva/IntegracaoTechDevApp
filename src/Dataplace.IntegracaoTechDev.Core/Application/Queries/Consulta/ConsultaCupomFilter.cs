using Dataplace.Core.Domain.Query;
using Dataplace.IntegracaoTechDev.Core.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Dataplace.IntegracaoTechDev.Core.Application.Queries.Cupom
{
    public class ConsultaCupomFilter : IQuery<IEnumerable<ConsultaCupomViewModel>>
    {
        public ConsultaCupomFilter(bool filtrarPorData, ConsultaCupomFilterDataEnum data, DateTime? dataInicio, DateTime? dataFim)
        {
            FiltrarPorData = filtrarPorData;
            Data = data;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

        public bool FiltrarPorData { get; private set; }
        public ConsultaCupomFilterDataEnum Data { get; private set; }
        public DateTime? DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; } 
    }

    public enum ConsultaCupomFilterDataEnum
    {
        Cupom
    }
}
