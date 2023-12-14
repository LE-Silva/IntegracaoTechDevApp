using Dataplace.Core.Comunications;
using Dataplace.Core.Domain.CommandHandlers;
using Dataplace.Core.Domain.Interfaces.UoW;
using Dataplace.Core.Domain.Localization.Messages.Extensions;
using Dataplace.Core.Domain.Notifications;
using Dataplace.Core.Shared.Financial.Contracts.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dataplace.IntegracaoTechDev.Core.Application.Commands.Ferramenta
{
    public class FerramentaCommandHandler : CommandHandler,
        IRequestHandler<ProcessarFerramentaCommand, bool>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMediatorHandler _mediatorHdl;

        public FerramentaCommandHandler(IUnitOfWork uow, IMediatorHandler mediator, INotificationHandler<DomainNotification> notifications) : base(uow, mediator, notifications)
        {
            _uow = uow;
            _mediatorHdl = mediator;
        }

        public async Task<bool> Handle(ProcessarFerramentaCommand request, CancellationToken cancellationToken)
        {
            var hashCodeTransaction = BeginTransaction();

            try
            {
                //Podemos usar o Padrão Validation para setar as Specifications do processo
                //Estando tudo OK podemos gravar no banco usando Repository

                //Só para teste, caso False irá retornar erro
                if (!request.Parametro1)
                    NotifyErrorValidation(nameof(ProcessarFerramentaCommand), "Erro");

                if (_mediatorNotifications.HasNotifications())
                    return false;

            }
            catch (Exception ex)
            {
                NotifyErrorValidation(nameof(ProcessarFerramentaCommand), ex.Message);
                return false;
            }
            finally
            {
                Commit(hashCodeTransaction);
            }

            return !_mediatorNotifications.HasNotifications();
        }
    }
}
