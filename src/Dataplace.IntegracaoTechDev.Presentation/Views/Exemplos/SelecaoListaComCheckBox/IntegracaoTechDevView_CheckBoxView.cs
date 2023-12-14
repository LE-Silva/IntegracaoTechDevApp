using Dataplace.Core.win.Controls.List.Delegates;
using Dataplace.Core.win.Views.Extensions;
using Dataplace.Core.win.Views;
using Dataplace.IntegracaoTechDev.Core.Application.ViewModels.SelectableListViewProvider;
using Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.SelectableListViewProvider.Providers;
using dpLibrary05;
using System;
using System.Data;
using System.Linq;
using Dataplace.Core.win.Controls.Extensions;
using Newtonsoft.Json;

namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.SelectableListViewProvider
{
    public partial class IntegracaoTechDevView_CheckBoxView : DPUserControl
    {
        public IntegracaoTechDevView_CheckBoxView()
        {
            InitializeComponent();
            SetComponents();

            btnFiltrar.Click += (object sender, EventArgs e) =>
            {
                //Será retornado uma lista de AreaSelectionViewModel com os registros selecionados
                txtRetorno.Text = JsonConvert.SerializeObject(chkAreaCliente.GetSelectedItems<AreaSelectionViewModel>());
            };
        }

        private void SetComponents()
        {
            //Área do Cliente
            var viewProviderArea = BootStrapper.Container.GetViewProvider<SelectableListView, AreaSelectionListViewProvider>();
            viewProviderArea.Filter += (object _sender, OnFilterEventArgs<AreaSelectionFilterViewModel> _e) =>
            {
                _e.Filter.CdEmpresa = dpLibrary05.mGenerico.SymPRM.cdempresa;
                _e.Filter.CdFilial = dpLibrary05.mGenerico.SymPRM.cdfilial;
            };

            chkAreaCliente.ConfigureSelector(viewProviderArea, setMemorySelectedItems: value =>
            {
                if ((string.IsNullOrEmpty(value)))
                    return;

                var listaValue = value.Split(",".ToCharArray()).ToList().Select(x => x.ToString().Trim()).ToList();
                if ((listaValue.Count > 0))
                {
                    viewProviderArea.ChangeCheckState(x =>
                    {
                        return listaValue.Contains($"'{x.CdArea.ToString().Trim()}'");
                    });
                }
            }, getMemorySelectedItems: values =>
            {
                return $"'{string.Join("','", values.Select(x => x.CdArea.Trim()))}'";
            });
        }
    }
}
