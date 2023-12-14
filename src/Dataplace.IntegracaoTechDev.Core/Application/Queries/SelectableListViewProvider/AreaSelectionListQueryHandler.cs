using Dapper;
using Dataplace.Core.Infra.Data.SqlConnection;
using Dataplace.IntegracaoTechDev.Core.Application.ViewModels.SelectableListViewProvider;
using dpLibrary05;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Dataplace.IntegracaoTechDev.Core.Application.Queries.SelectableListViewProvider
{
    public class AreaSelectionListQueryHandler : IRequestHandler<AreaSelectionFilterViewModel, IEnumerable<AreaSelectionViewModel>>
    {
        private readonly IDataAccess _dataAccess;

        public AreaSelectionListQueryHandler(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<AreaSelectionViewModel>> Handle(AreaSelectionFilterViewModel request, CancellationToken cancellationToken)
        {
            var sql = @"
                      SET TRANSACTION ISOLATION LEVEL SNAPSHOT;
                      SELECT 
                            PlanoArea.CdArea, 
                            PlanoArea.Descricao
                      FROM PlanoArea
                      ";
            return _dataAccess.Connection.Query<AreaSelectionViewModel>(sql);
        }

    }
}
