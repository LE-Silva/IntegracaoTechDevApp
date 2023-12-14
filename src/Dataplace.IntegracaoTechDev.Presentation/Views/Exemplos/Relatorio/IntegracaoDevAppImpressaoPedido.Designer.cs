namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Relatorio
{
    partial class IntegracaoDevAppImpressaoPedido
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkExibirItens = new System.Windows.Forms.CheckBox();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.pnSystemParameters.SuspendLayout();
            this.tpSystemParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSystemParameters
            // 
            this.pnSystemParameters.Controls.Add(this.txtNumPedido);
            this.pnSystemParameters.Controls.Add(this.chkExibirItens);
            // 
            // chkExibirItens
            // 
            this.chkExibirItens.AutoSize = true;
            this.chkExibirItens.Location = new System.Drawing.Point(42, 70);
            this.chkExibirItens.Name = "chkExibirItens";
            this.chkExibirItens.Size = new System.Drawing.Size(77, 17);
            this.chkExibirItens.TabIndex = 0;
            this.chkExibirItens.Text = "Exibir Itens";
            this.chkExibirItens.UseVisualStyleBackColor = true;
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPedido.Location = new System.Drawing.Point(42, 40);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(100, 26);
            this.txtNumPedido.TabIndex = 1;
            // 
            // IntegracaoDevAppImpressaoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "IntegracaoDevAppImpressaoPedido";
            this.pnSystemParameters.ResumeLayout(false);
            this.pnSystemParameters.PerformLayout();
            this.tpSystemParameters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkExibirItens;
        private System.Windows.Forms.TextBox txtNumPedido;
    }
}
