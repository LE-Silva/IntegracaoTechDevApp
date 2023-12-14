using dpLibrary05;
using dpLibrary05.Infrastructure.UserControls;
using System.Windows.Forms;

namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Dialog
{
    public partial class IntegracaoTechDevView_DialogView : ucSymGen_Dialog
    {
        public IntegracaoTechDevView_DialogView()
        {
            InitializeComponent();
            SetComponents();

            this.OnDialogResult += OnDialogResultEvent;
        }

        private void OnDialogResultEvent(object sender, DialogResultEventArgs e)
        {
            if (e.DialogResult != DialogResult.OK)
            {
                MessageForm.Error("Cancelou");
                e.cancel = true;
            }
            else
                MessageForm.Info("Clicou em OK");
        }

        private void SetComponents()
        {

        }
    }
}
