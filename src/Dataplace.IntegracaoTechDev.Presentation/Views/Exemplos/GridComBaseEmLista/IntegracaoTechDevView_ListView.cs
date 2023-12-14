using Dataplace.Core.Application.Services.Results;
using Dataplace.Core.Domain.Entities;
using Dataplace.Core.win.Controls.List.Behaviors;
using Dataplace.Core.win.Controls.List.Behaviors.Contracts;
using Dataplace.Core.win.Controls.List.Configurations;
using Dataplace.IntegracaoTechDev.Core.Application.ViewModels.ListBehavior;
using dpLibrary05;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.ListBehavior
{
    public partial class IntegracaoTechDevView_ListView : DPUserControl
    {
        private IListBehavior<ClienteListBehaviorViewModel, ClienteListBehaviorFilterViewModel> _listBehavior;

        public IntegracaoTechDevView_ListView()
        {
            InitializeComponent();
            SetComponents();
            InitializeList();

            btnCarregar.Click += (object sender, System.EventArgs e) =>
            {
                _listBehavior.Load();
            };

            btnInserir.Click += (object sender, System.EventArgs e) =>
            {
                InsertItemListBehavior();
            };

            btnNotificar.Click += (object sender, System.EventArgs e) =>
            {
                CarregarNotificacoes();
            };

            btnLimpar.Click += (object sender, System.EventArgs e) =>
            {
                _listBehavior.Load(new List<ClienteListBehaviorViewModel>());
            };
        }

        private void SetComponents()
        {

        }

        #region GridListBehavior
        private void InitializeList()
        {
            //Inicializando a lista e carregando o grid
            _listBehavior = C1TrueDBGridListBehavior<ClienteListBehaviorViewModel, ClienteListBehaviorFilterViewModel>.FactoryAsync(this.tdbgLista, GetItems, Configure);
            _listBehavior.Load(new List<ClienteListBehaviorViewModel>());
            _listBehavior.FilterBar = true;
            _listBehavior.MultiSelect = true;
        }

        private async Task<IEnumerable<ClienteListBehaviorViewModel>> GetItems(ClienteListBehaviorFilterViewModel query, IEnumerable<SortDescriptor> arg2)
        {
            //Carregado itens no grid (Está fixo por lista, poderíamos carregá-la do banco de dados usando o Padrão Query)
            var list = new List<ClienteListBehaviorViewModel>();
            var rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                var cont = rnd.Next(1, 1000);

                list.Add(new ClienteListBehaviorViewModel()
                {
                    IsSelected = (i % 2) == 0 ? true : false, //CheckBox do grid marcado ou desmarcado
                    CdCliente = cont.ToString(),
                    Razao = $"RAZÃO SOCIAL {cont}",
                    Fantasia = $"FANTASIA {cont}"
                });
            }
            
            return list;
        }

        private void Configure(ViewModelListBuilder<ClienteListBehaviorViewModel> configure)
        {
            //Setado colunas
            configure.Property(x => x.CdCliente)
                .HasCaption("Cliente")
                .HasMinWidth(100);
            configure.Property(x => x.Razao)
                .HasCaption("Razão Social")
                .HasMinWidth(300);

            configure.Ignore(x => x.Fantasia);

            configure.SetAllowSort(true);
        }

        private void InsertItemListBehavior()
        {
            var rnd = new Random();
            var cont = rnd.Next(1, 1000);

            _listBehavior.AddItem(new ClienteListBehaviorViewModel()
            {
                CdCliente = cont.ToString(),
                Razao = $"RAZÃO SOCIAL {cont}",
                Fantasia = $"FANTASIA {cont}"
            });
        }

        private void CarregarNotificacoes()
        {
            //Utilizamos em processamentos para informar se processou com sucesso ou ocorreu erro, retornando os erros de cada registro
            foreach (var item in _listBehavior.GetAllItems())
            {
                if (!item.IsSelected)
                    item.Result = Result.ResultFactory.New("Erro");
                else
                    item.Result = Result.ResultFactory.OK();
            }

            tdbgLista.Refresh();
        }
        #endregion
    }
}
