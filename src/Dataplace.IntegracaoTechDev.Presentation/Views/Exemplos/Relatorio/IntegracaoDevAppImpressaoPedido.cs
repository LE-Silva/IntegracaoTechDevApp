using dpLibrary05.Infrastructure.UserControls;
using System;

namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Relatorio
{
    public partial class IntegracaoDevAppImpressaoPedido : ucSymGen_ReportDialog
    {
        private LookUpEdit.IntegracaoTechDevView_LookUpEditPesquisaView pesquisaViewPedido;

        public IntegracaoDevAppImpressaoPedido()
        {
            InitializeComponent();
            OnConfiguration();
        }

        private void OnConfiguration()
        {
            this.BeforeLoadReport += OnBeforeLoadReport;
            this.LoadReport += OnLoadReport;
            this.ReportConfiguration += OnReportConfiguration;
        }

        private void OnBeforeLoadReport(object sender, BeforeLoadReportEventArgs e)
        {
            try
            {
                //if (!chkExibirItens.Checked)
                //{
                //    e.Cancel = true;
                //    e.CancelControl = chkExibirItens;
                //    e.CancelMessage = "Marque a opção";
                //    return;
                //}

                var feExibir = chkExibirItens.Checked;
                e.Parameter.Items.Add(nameof(feExibir), feExibir);
            }
            catch (Exception ex)
            {
                e.CancelMessage = ex.Message;
                e.Cancel = true;
                e.CancelReason = ReportStateEnum.Err;
                return;
            }
        }

        private void OnLoadReport(object sender, LoadReportEventArgs e)
        {
            try
            {
                bool feExibir;
                feExibir = (bool)e.Parameter.Items.get_ItemByName(nameof(feExibir)).Value;

                int numPedido;
                int.TryParse(txtNumPedido.Text, out numPedido);

                var report = ReportList[50000];

                //Parâmetros passado para o Designer do Report, exemplo algum componente
                report.Formulas.Items.Add("titulo", "Impressão");
                report.Formulas.Items.Add("feNumPedido", numPedido);
                report.Formulas.Items.Add("feExibir",  feExibir);

                //Parâmetro passado ao datasource do Relatório
                report.Parametros.Items.Add("feNumPedido", numPedido);
                report.Formulas.Items.Add("feExibir", feExibir);

                e.ReportData = report;
            }
            catch (Exception ex)
            {
                e.CancelMessage = ex.Message;
                e.Cancel = true;
                e.CancelReason = ReportStateEnum.Err;
                return;
            }
        }

        private void OnReportConfiguration(object sender, ReportConfigurationEventArgs e)
        {
            e.ReportList.Add(50000,
                             new dpLibrary05.SymphonyReport.clsSymReport.ReportData(true)
                             {
                                 Id = 5000013,
                                 ItemSeg = 166.ToString(),
                                 Name = "Impressão do Pedido"
                             });
            e.SecurityIdList.Add(50000);
        }
    }
}
