using dpLibrary05.Infrastructure.UserControls;
using System;

namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Relatorio
{
    public partial class Pesquisa : ucSymGen_ReportDialog
    {
        private LookUpEdit.IntegracaoTechDevView_LookUpEditPesquisaView pesquisaFonetica;

        public Pesquisa()
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
            //try
            //{
            //    if (!chkParametro.Checked)
            //    {
            //        e.Cancel = true;
            //        e.CancelControl = chkParametro;
            //        e.CancelMessage = "Marque a opção";
            //        return;
            //    }
            //
            //    var parametro = chkParametro.Checked;
            //    e.Parameter.Items.Add(nameof(parametro), parametro);
            //}
            //catch (Exception ex)
            //{
            //    e.CancelMessage = ex.Message;
            //    e.Cancel = true;
            //    e.CancelReason = ReportStateEnum.Err;
            //    return;
            //}
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
                                 Id = 5000013,
                                 ItemSeg = 166.ToString(),
                                 Name = "Relatório"
                             });
            e.SecurityIdList.Add(50000);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa));
            this.pesquisaFonetica = new Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.LookUpEdit.IntegracaoTechDevView_LookUpEditPesquisaView();
            this.pnSystemParameters.SuspendLayout();
            this.tpSystemParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSystemParameters
            // 
            this.pnSystemParameters.Controls.Add(this.pesquisaFonetica);
            // 
            // pesquisaFonetica
            // 
            this.pesquisaFonetica.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pesquisaFonetica.DotNetContainer = false;
            this.pesquisaFonetica.KeyPreview = false;
            this.pesquisaFonetica.Location = new System.Drawing.Point(19, 19);
            this.pesquisaFonetica.Name = "pesquisaFonetica";
            this.pesquisaFonetica.OpenModal = false;
            this.pesquisaFonetica.Parameters = ((System.Collections.Generic.IDictionary<string, object>)(resources.GetObject("pesquisaFonetica.Parameters")));
            this.pesquisaFonetica.Size = new System.Drawing.Size(511, 109);
            this.pesquisaFonetica.TabIndex = 0;
            this.pesquisaFonetica.TabOrderScheme = dpLibrary05.TabOrderManager.TabScheme.None;
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "Pesquisa";
            this.pnSystemParameters.ResumeLayout(false);
            this.tpSystemParameters.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
