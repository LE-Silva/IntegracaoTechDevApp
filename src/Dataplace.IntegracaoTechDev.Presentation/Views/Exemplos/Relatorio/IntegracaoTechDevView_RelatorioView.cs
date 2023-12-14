using dpLibrary05.Infrastructure.UserControls;
using System;

namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Relatorio
{
    public partial class IntegracaoTechDevView_RelatorioView : ucSymGen_ReportDialog
    {
        public IntegracaoTechDevView_RelatorioView()
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
                if (!chkParametro.Checked)
                {
                    e.Cancel = true;
                    e.CancelControl = chkParametro;
                    e.CancelMessage = "Marque a opção";
                    return;
                }

                var parametro = chkParametro.Checked;
                e.Parameter.Items.Add(nameof(parametro), parametro);
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
                bool parametro;
                parametro = (bool)e.Parameter.Items.get_ItemByName(nameof(parametro)).Value;

                var report = ReportList[50000];

                //Parâmetros passado para o Designer do Report, exemplo algum componente
                report.Formulas.Items.Add("titulo", "Título do Relatório");

                //Parâmetro passado ao datasource do Relatório
                report.Parametros.Items.Add("parametro", parametro);

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
                                 Id = 50000,
                                 ItemSeg = 166.ToString(),
                                 Name = "Relatório"
                             });
            e.SecurityIdList.Add(50000);
        }
    }
}
