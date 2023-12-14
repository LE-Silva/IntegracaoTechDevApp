namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.ControlesDP
{
    partial class IntegracaoTechDev_ControlesView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dpInput1 = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpComboBox1 = new dpLibrary05.Infrastructure.Controls.DPComboBox();
            this.SuspendLayout();
            // 
            // dpInput1
            // 
            this.dpInput1.Active = false;
            this.dpInput1.DataSource = null;
            this.dpInput1.DP_Caption = "dpInput1";
            this.dpInput1.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpInput1.DP_DataField = null;
            this.dpInput1.DP_FilterMemo = false;
            this.dpInput1.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.None;
            this.dpInput1.DP_Length = 0;
            this.dpInput1.DP_Maximum = null;
            this.dpInput1.DP_Minimum = null;
            this.dpInput1.DP_NumericPrecision = 0;
            this.dpInput1.EditMask = null;
            this.dpInput1.EditMaskUpdate = false;
            this.dpInput1.FindMode = false;
            this.dpInput1.InterfaceField = null;
            this.dpInput1.IsReadonly = false;
            this.dpInput1.Location = new System.Drawing.Point(18, 25);
            this.dpInput1.Multiline = false;
            this.dpInput1.Name = "dpInput1";
            this.dpInput1.SearchObject = null;
            this.dpInput1.SettingValue = false;
            this.dpInput1.Size = new System.Drawing.Size(191, 39);
            this.dpInput1.TabIndex = 0;
            // 
            // dpComboBox1
            // 
            this.dpComboBox1.Active = false;
            this.dpComboBox1.AllowTextValue = false;
            this.dpComboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.dpComboBox1.DP_DataField = null;
            this.dpComboBox1.DP_FilterMemo = false;
            this.dpComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dpComboBox1.FindMode = false;
            this.dpComboBox1.FormattingEnabled = true;
            this.dpComboBox1.InterfaceField = null;
            this.dpComboBox1.IsReadonly = false;
            this.dpComboBox1.Location = new System.Drawing.Point(18, 81);
            this.dpComboBox1.Name = "dpComboBox1";
            this.dpComboBox1.SettingValue = false;
            this.dpComboBox1.Size = new System.Drawing.Size(191, 21);
            this.dpComboBox1.TabIndex = 1;
            // 
            // IntegracaoTechDev_ControlesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dpComboBox1);
            this.Controls.Add(this.dpInput1);
            this.Name = "IntegracaoTechDev_ControlesView";
            this.Size = new System.Drawing.Size(240, 137);
            this.ResumeLayout(false);

        }

        #endregion

        private dpLibrary05.Infrastructure.Controls.DPInput dpInput1;
        private dpLibrary05.Infrastructure.Controls.DPComboBox dpComboBox1;
    }
}
