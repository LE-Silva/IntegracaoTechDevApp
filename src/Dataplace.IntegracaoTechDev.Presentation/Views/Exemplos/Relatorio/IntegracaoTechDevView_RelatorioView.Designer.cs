namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Relatorio
{
    partial class IntegracaoTechDevView_RelatorioView
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
            this.chkParametro = new System.Windows.Forms.CheckBox();
            this.pnSystemParameters.SuspendLayout();
            this.tpSystemParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSystemParameters
            // 
            this.pnSystemParameters.Controls.Add(this.chkParametro);
            this.pnSystemParameters.Size = new System.Drawing.Size(656, 308);
            // 
            // tpSystemParameters
            // 
            this.tpSystemParameters.Size = new System.Drawing.Size(656, 308);
            // 
            // chkParametro
            // 
            this.chkParametro.AutoSize = true;
            this.chkParametro.Location = new System.Drawing.Point(25, 17);
            this.chkParametro.Name = "chkParametro";
            this.chkParametro.Size = new System.Drawing.Size(83, 17);
            this.chkParametro.TabIndex = 0;
            this.chkParametro.Text = "Parâmetro 1";
            this.chkParametro.UseVisualStyleBackColor = true;
            // 
            // IntegracaoTechDevView_RelatorioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "IntegracaoTechDevView_RelatorioView";
            this.Size = new System.Drawing.Size(662, 400);
            this.pnSystemParameters.ResumeLayout(false);
            this.pnSystemParameters.PerformLayout();
            this.tpSystemParameters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkParametro;
    }
}
