using Dataplace.Core.Domain.Commands;

namespace Dataplace.IntegracaoTechDev.Core.Application.Commands.Ferramenta
{
    public class ProcessarFerramentaCommand : Command
    {
        public ProcessarFerramentaCommand(bool parametro1)
        {
            Parametro1 = parametro1;
        }

        public bool Parametro1 { get; private set; }
    }
}
