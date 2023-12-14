namespace Dataplace.IntegracaoTechDev.Presentation.TesteViews.Relatorio
{
    partial class IntegracaoDevApp_RelatorioView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntegracaoDevApp_RelatorioView));
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.chkExibirItens = new System.Windows.Forms.CheckBox();
            this.integracaoDevApp_PesquisaFoneticaView1 = new Dataplace.IntegracaoTechDev.Presentation.IntegracaoNovasViews.Pesquisa.IntegracaoDevApp_PesquisaFoneticaView();
            this.pnSystemParameters.SuspendLayout();
            this.tpSystemParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSystemParameters
            // 
            this.pnSystemParameters.Controls.Add(this.integracaoDevApp_PesquisaFoneticaView1);
            this.pnSystemParameters.Controls.Add(this.chkExibirItens);
            this.pnSystemParameters.Controls.Add(this.txtNumPedido);
            this.pnSystemParameters.Size = new System.Drawing.Size(794, 358);
            // 
            // tpSystemParameters
            // 
            this.tpSystemParameters.Size = new System.Drawing.Size(794, 358);
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPedido.Location = new System.Drawing.Point(33, 43);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(129, 29);
            this.txtNumPedido.TabIndex = 0;
            // 
            // chkExibirItens
            // 
            this.chkExibirItens.AutoSize = true;
            this.chkExibirItens.Location = new System.Drawing.Point(33, 91);
            this.chkExibirItens.Name = "chkExibirItens";
            this.chkExibirItens.Size = new System.Drawing.Size(128, 17);
            this.chkExibirItens.TabIndex = 1;
            this.chkExibirItens.Text = "Exibir Itens do Pedido";
            this.chkExibirItens.UseVisualStyleBackColor = true;
            // 
            // integracaoDevApp_PesquisaFoneticaView1
            // 
            this.integracaoDevApp_PesquisaFoneticaView1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.integracaoDevApp_PesquisaFoneticaView1.DotNetContainer = false;
            this.integracaoDevApp_PesquisaFoneticaView1.KeyPreview = false;
            this.integracaoDevApp_PesquisaFoneticaView1.Location = new System.Drawing.Point(18, 117);
            this.integracaoDevApp_PesquisaFoneticaView1.Name = "integracaoDevApp_PesquisaFoneticaView1";
            this.integracaoDevApp_PesquisaFoneticaView1.OpenModal = false;
            this.integracaoDevApp_PesquisaFoneticaView1.Parameters = ((System.Collections.Generic.IDictionary<string, object>)(resources.GetObject("integracaoDevApp_PesquisaFoneticaView1.Parameters")));
            this.integracaoDevApp_PesquisaFoneticaView1.Size = new System.Drawing.Size(754, 89);
            this.integracaoDevApp_PesquisaFoneticaView1.TabIndex = 12;
            this.integracaoDevApp_PesquisaFoneticaView1.TabOrderScheme = dpLibrary05.TabOrderManager.TabScheme.None;
            // 
            // IntegracaoDevApp_RelatorioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "IntegracaoDevApp_RelatorioView";
            this.Size = new System.Drawing.Size(800, 450);
            this.pnSystemParameters.ResumeLayout(false);
            this.pnSystemParameters.PerformLayout();
            this.tpSystemParameters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.CheckBox chkExibirItens;
        private IntegracaoNovasViews.Pesquisa.IntegracaoDevApp_PesquisaFoneticaView integracaoDevApp_PesquisaFoneticaView1;
    }
}