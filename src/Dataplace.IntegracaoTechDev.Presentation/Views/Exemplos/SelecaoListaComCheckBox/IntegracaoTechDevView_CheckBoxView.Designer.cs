namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.SelectableListViewProvider
{
    partial class IntegracaoTechDevView_CheckBoxView
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
            this.chkAreaCliente = new System.Windows.Forms.CheckBox();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkAreaCliente
            // 
            this.chkAreaCliente.AutoSize = true;
            this.chkAreaCliente.Location = new System.Drawing.Point(24, 21);
            this.chkAreaCliente.Name = "chkAreaCliente";
            this.chkAreaCliente.Size = new System.Drawing.Size(149, 17);
            this.chkAreaCliente.TabIndex = 0;
            this.chkAreaCliente.Text = "Filtrar por Área de Clientes";
            this.chkAreaCliente.UseVisualStyleBackColor = true;
            // 
            // txtRetorno
            // 
            this.txtRetorno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRetorno.Location = new System.Drawing.Point(24, 102);
            this.txtRetorno.Multiline = true;
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.Size = new System.Drawing.Size(334, 77);
            this.txtRetorno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Retorno Filtro";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(283, 17);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // IntegracaoTechDevView_CheckBoxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRetorno);
            this.Controls.Add(this.chkAreaCliente);
            this.Name = "IntegracaoTechDevView_CheckBoxView";
            this.Size = new System.Drawing.Size(395, 196);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAreaCliente;
        private System.Windows.Forms.TextBox txtRetorno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
    }
}
