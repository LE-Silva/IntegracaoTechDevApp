using dpLibrary05;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.EnvioEmail
{
    public partial class IntegracaoTechDevView_EnvioEmailView : DPUserControl
    {
        public IntegracaoTechDevView_EnvioEmailView()
        {
            InitializeComponent();

            btnEnviar.Click += BtnEnviar_Click;
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            EnviarEmail();
        }

        private void EnviarEmail()
        {
            object teste;
            teste = new DPLibrary01.clsEnvioEmail();
            var email = new DPLibrary01.clsEnvioEmail();
            email.strEnviarDireto = "N";
            email.EnviarEmail_SYM(ref teste);

            //SendEmailWithEngineCode
        }
    }
}
