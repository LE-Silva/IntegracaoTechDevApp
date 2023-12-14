using Dataplace.IntegracaoTechDev.Presentation.Commom.Search;
using dpLibrary05;
using dpLibrary05.Infrastructure.Helpers;

namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.LookUpEdit
{
    public partial class IntegracaoTechDevView_LookUpEditPesquisaView : DPUserControl
    {
        public IntegracaoTechDevView_LookUpEditPesquisaView()
        {
            InitializeComponent();
            SetControls();
            SetSearchs();
        }

        private void SetControls()
        {

        }

        private void SetSearchs()
        {
            var searchMarca = IntegracaoTechDevSearch.Find_Marca(new clsSymSearch.SearchArgs() { });
            searchMarca.SetaAzul = false;

            searchMarca.BeforeSearch += (object sender, dpLibrary05.SymphonyInterface.BeforeSearchEventArgs e) =>
            {
                e.SearchObject.Filter = "1=1";
            };

            searchMarca.AfterSearch += (object sender, dpLibrary05.SymphonyInterface.AfterSearchEventArgs e) =>
            {
                if (!e.result)
                    luePesquisa.Focus();
            };

            luePesquisa.SearchObject = searchMarca;
        }
    }
}
