using Dapper;
using Dataplace.Core.Infra.Data.SqlConnection;
using Dataplace.IntegracaoTechDev.Core.Application.ViewModels;
using MediatR;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dataplace.IntegracaoTechDev.Core.Application.Queries.Cupom
{
    public class CupomQueryHandler : IRequestHandler<ConsultaCupomFilter, IEnumerable<ConsultaCupomViewModel>>
    {
        #region Constructor
        private readonly ISqlDataAccess _dataAccess;

        public CupomQueryHandler(
            ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        private IDbConnection GetConnection()
        {
            return _dataAccess.Connection;
        }
        #endregion

        public async Task<IEnumerable<ConsultaCupomViewModel>> Handle(ConsultaCupomFilter request, CancellationToken cancellationToken)
        {
            var query = new StringBuilder();
            query.AppendLine("SELECT Cupom.NumCupomECF")
                .AppendLine(", Cupom.ECFSerie ")
                .AppendLine(", Cupom.DataCupom ")
                .AppendLine("FROM Cupom")
                .AppendLine("/**WHERE**/")
                .AppendLine("/**ORDERBY**/");

            SqlBuilder builder = new SqlBuilder();
            var selector = builder.AddTemplate(query.ToString());
            //builder.Where("caixa.codigo = @codigo", new { codigo = request.Caixa });
            //builder.Where("caixa.cdempresa = @cdempresa", new { cdempresa = request.CdEmpresa });
            //builder.Where("caixa.cdfilial = @cdfilial", new { cdfilial = request.CdFilial });
            //builder.Where("caixa.StAtivo = 1");

            return GetConnection().Query<ConsultaCupomViewModel>(selector.RawSql, selector.Parameters);
        }
    }
}
