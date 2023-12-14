using Dataplace.Core.Domain.Localization.Messages.Extensions;
using dpLibrary05.SymphonyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static dpLibrary05.Infrastructure.Helpers.clsSymSearch;

namespace Dataplace.IntegracaoTechDev.Presentation.IntegracaoNovasViews.Search
{
    public class IntegracaoDevApp_Search
    {
        public static ISymInterfaceSearch Find_Marca(SearchArgs args = default(SearchArgs))
        {
            ISymInterfaceSearch se = DefaultInstance();
            se.Title = 7571.ToMessage();

            se.SecurityID = 88;
            se.Id = nameof(Find_Marca);
            se.SetaAzul = true;

            se.Source = "SELECT marca, descricao FROM Marca";

            se.MethodSort = "marca";

            //Código
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 0, Name = "Código", Width = 80, IsReturnValue = true });

            //Descrição
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 1, Name = "Descrição", Width = 300 });

            SetParameters(ref se, args);
            return se;
        }

        public static ISymInterfaceSearch Find_ClienteDevApp(SearchArgs args = default(SearchArgs))
        {
            ISymInterfaceSearch se = DefaultInstance();
            se.Title = 7571.ToMessage();
            se.SecurityID = 88;
            se.Id = nameof(Find_ClienteDevApp);
            se.SetaAzul = true;
            se.SetaAzul = true;

            se.Source = "SELECT CdCliente, Nome, Cpf, TpPessoa, StClientePremium, StAtivo FROM ClienteAtv2510";

            se.MethodSort = "Nome";

            //Campos
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 0, Name = "Código", Width = 70, IsReturnValue = true });
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 1, Name = "Nome", Width = 270 });
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 2, Name = "Cpf", Width = 100 });
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 3, Name = "TpPessoa", ColumnName = "Tipo de Pessoa", Width = 80 });
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 4, Name = "StClientePremium", ColumnName = "Cliente Premium", Width = 80 });
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 5, Name = "StAtivo", ColumnName = "Status" ,Width = 80 });

            SetParameters(ref se, args);
            return se;
        }
    }
}
