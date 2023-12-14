using Dataplace.Core.Application.Contracts.Results;
using Dataplace.Core.Application.Services.Results;
using Dataplace.Core.Comunications;
using Dataplace.Core.Domain.Notifications;
using Dataplace.Core.Infra.Data.Extensions;
using Dataplace.Core.win.Views.Extensions;
using Dataplace.IntegracaoTechDev.Core.Application.Commands.Ferramenta;
using dpLibrary05;
using dpLibrary05.Infrastructure.UserControls;
using MediatR;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Ferramenta
{
    public partial class IntegracaoTechDev_FerramentaView : ucSymGen_ToolDialog
    {
        public IntegracaoTechDev_FerramentaView()
        {
            InitializeComponent();

            onConfiguration();
        }

        private void onConfiguration()
        {
            this.BeforeProcess += onBeforeProcess;
            this.Process += onProcess;
            this.AfterProcess += onAfterProcess;
            this.ToolConfiguration += onToolConfiguration;
            this.ParametersChange += onParametersChange;
        }

        private void onBeforeProcess(object sender, BeforeProcessEventArgs e)
        {
            try
            {
                if (MessageForm.Ask("Deseja continuar?", MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.CancelMessage = "Usuário Cancelou!";
                    e.Cancel = true;
                    return;
                }

                //Passar decisões de tela por parâmetro, como qual checkbox marcado, etc
                var parametro1 = chkParametro1.Checked;
                e.Parameter.Items.Add(nameof(parametro1), parametro1);
            }
            catch (Exception ex)
            {
                e.CancelMessage = ex.Message;
                e.Cancel = true;
                e.CancelReason = ToolStateEnum.Err;
                return;
            } 
        }

        private void onProcess(object sender, ProcessEventArgs e)
        {
            try
            {
                bool parametro1;
                parametro1 = (bool)e.Parameter.get_ItemsByName(nameof(parametro1)).Value;

                e.ProgressMaximum = 10;
                e.LogBuilder.Items.Add("Informativo", dpLibrary05.Infrastructure.Helpers.LogBuilder.LogTypeEnum.Information);
                e.LogBuilder.Items.Add("Aviso", dpLibrary05.Infrastructure.Helpers.LogBuilder.LogTypeEnum.Warning);

                var result = this.WithScope((IMediatorHandler mediator, INotificationHandler<DomainNotification> domainNotification) =>
                {
                    var command = new ProcessarFerramentaCommand(parametro1);
                    mediator.SendCommand(command).GetAwaiter().GetResult();

                    return Result.ResultFactory.New(domainNotification.GetNotifications());
                });

                for (int i = 0; i < 10; i++)
                {
                    e.ProgressValue = i;
                    Thread.Sleep(100);
                }

                if (!result.Success)
                    e.LogBuilder.Items.Add("Erro", dpLibrary05.Infrastructure.Helpers.LogBuilder.LogTypeEnum.Err);

                e.Parameter.Items.Add(nameof(result), result);
            }
            catch (Exception ex)
            {
                e.CancelMessage = ex.ShowMessage();
                e.Cancel = true;
                e.CancelReason = ToolStateEnum.Err;
                return;
            }
        }

        private void onAfterProcess(object sender, AfterProcessEventArgs e)
        {
            if (e.Parameter.Items.Contains("result"))
            {
                var result = (IResult)e.Parameter.get_ItemsByName("result").Value;
                if (result.Success)
                    MessageForm.Info("After Process Success");
            }
        }

        private void onToolConfiguration(object sender, ToolConfigurationEventArgs e)
        {
            e.SecurityIdList.Add(166);
        }

        private void onParametersChange(object sender, EventArgs e)
        {
            //Passar parâmetros para a ferramenta
        }
    }
}
