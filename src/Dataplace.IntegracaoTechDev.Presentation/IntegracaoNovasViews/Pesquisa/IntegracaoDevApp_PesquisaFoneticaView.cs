using Dataplace.IntegracaoTechDev.Presentation.Commom.Search;
using Dataplace.IntegracaoTechDev.Presentation.IntegracaoNovasViews.Search;
using dpLibrary05;
using dpLibrary05.Infrastructure.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dataplace.IntegracaoTechDev.Presentation.IntegracaoNovasViews.Pesquisa
{
    public partial class IntegracaoDevApp_PesquisaFoneticaView : DPUserControl
    {
        public IntegracaoDevApp_PesquisaFoneticaView()
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
            //var searchMarca = IntegracaoTechDevSearch.Find_Marca(new clsSymSearch.SearchArgs() { });
            var searchMarca = IntegracaoDevApp_Search.Find_ClienteDevApp(new clsSymSearch.SearchArgs { });
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
