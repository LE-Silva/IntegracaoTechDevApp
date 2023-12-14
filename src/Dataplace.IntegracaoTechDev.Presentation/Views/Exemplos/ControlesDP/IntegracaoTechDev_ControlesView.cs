using dpLibrary05;
using dpLibrary05.Infrastructure.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.ControlesDP
{
    public partial class IntegracaoTechDev_ControlesView : DPUserControl
    {
        public IntegracaoTechDev_ControlesView()
        {
            InitializeComponent();
            LoadComboBoxDpInput();

            dpComboBox1.SelectedValueChanged += (object sender, EventArgs e) =>
            {
                dpInput1.DP_InputType = (DPInput.InputTypeEnum)dpComboBox1.GetValue();
                dpInput1.Refresh();
            };
        }

        private void LoadComboBoxDpInput()
        {
            var list = new Dictionary<DPInput.InputTypeEnum, string>();
            foreach (var elemento in Enum.GetValues(typeof(DPInput.InputTypeEnum)))
                list.Add((DPInput.InputTypeEnum)elemento, elemento.ToString());

            dpComboBox1.DisplayMember = "Value";
            dpComboBox1.ValueMember = "Key";
            dpComboBox1.DataSource = new BindingSource(list, null);
        }
    }
}
