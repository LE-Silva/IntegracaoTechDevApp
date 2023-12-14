using Dataplace.IntegracaoTechDev.Presentation.TesteViews.Relatorio;
using Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Consulta;
using Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.ControlesDP;
using Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Dialog;
using Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.EnvioEmail;
using Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Ferramenta;
using Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.ListBehavior;
using Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.LookUpEdit;
using Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Relatorio;
using Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.SelectableListViewProvider;
using dpLibrary05;
using System;
using System.Windows.Forms;

namespace Dataplace.IntegracaoTechDev
{
    public partial class MainView : fMNU_Principal
    {
        public MainView()
        {
            InitializeComponent();

            this.Shown += (object sender, EventArgs e) =>
            {
                this.Text = "Dataplace TechDev";
            };

            LoadMenu();
        }

        private void LoadMenu()
        {
            //Arquivo
            AddMenu(new ToolStripMenuItem("Consulta", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<IntegracaoTechDevView_ConsultaCupom>(captionForm: "Consulta");
            }), TipoMenuEnun.Arquivo);

            AddMenu(new ToolStripMenuItem("Controles DP", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<IntegracaoTechDev_ControlesView>(captionForm: "Controles DP");
            }), TipoMenuEnun.Arquivo);

            //AddMenu(new ToolStripMenuItem("Envio Email", null, (object sender, EventArgs e) =>
            //{
            //    Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<IntegracaoTechDevView_EnvioEmailView>();
            //}), TipoMenuEnun.TabelaDeControle);

            AddMenu(new ToolStripMenuItem("Ferramenta", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<IntegracaoTechDev_FerramentaView>(captionForm: "Ferramenta");
            }), TipoMenuEnun.Arquivo);

            AddMenu(new ToolStripMenuItem("Grid com base em Lista", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<IntegracaoTechDevView_ListView>(captionForm: "Grid com base em Lista");
            }), TipoMenuEnun.Arquivo);

            AddMenu(new ToolStripMenuItem("Janela de Diálogo", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<IntegracaoTechDevView_DialogView>(captionForm: "Janela de Diálogo");
            }), TipoMenuEnun.Arquivo);

            AddMenu(new ToolStripMenuItem("Pesquisa Fonética", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<IntegracaoTechDevView_LookUpEditPesquisaView>(captionForm: "Pesquisa Fonética");
            }), TipoMenuEnun.Arquivo);

            AddMenu(new ToolStripMenuItem("Relatório", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<IntegracaoTechDevView_RelatorioView>(captionForm: "Relatório");
            }), TipoMenuEnun.Arquivo);

            AddMenu(new ToolStripMenuItem("Seleção em Lista com CheckBox", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<IntegracaoTechDevView_CheckBoxView>(captionForm: "Seleção em Lista com CheckBox");
            }), TipoMenuEnun.Arquivo);

            AddMenu(new ToolStripMenuItem("Impressão de Pedido", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<IntegracaoDevApp_RelatorioView>(captionForm: "Impressão");
            }), TipoMenuEnun.Arquivo);
        }
    }
}
