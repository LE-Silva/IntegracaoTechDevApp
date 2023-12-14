namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.ListBehavior
{
    partial class IntegracaoTechDevView_ListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntegracaoTechDevView_ListView));
            this.tdbgLista = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnNotificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tdbgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // tdbgLista
            // 
            this.tdbgLista.AllowAddNew = true;
            this.tdbgLista.AllowDelete = true;
            this.tdbgLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tdbgLista.GroupByCaption = "Drag a column header here to group by that column";
            this.tdbgLista.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbgLista.Images"))));
            this.tdbgLista.Location = new System.Drawing.Point(3, 70);
            this.tdbgLista.Name = "tdbgLista";
            this.tdbgLista.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.tdbgLista.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.tdbgLista.PreviewInfo.ZoomFactor = 75D;
            this.tdbgLista.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.tdbgLista.PrintInfo.MeasurementPrinterName = null;
            this.tdbgLista.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("tdbgLista.PrintInfo.PageSettings")));
            this.tdbgLista.Size = new System.Drawing.Size(549, 194);
            this.tdbgLista.TabAcrossSplits = true;
            this.tdbgLista.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.GridNavigation;
            this.tdbgLista.TabIndex = 501;
            this.tdbgLista.UseCompatibleTextRendering = false;
            this.tdbgLista.PropBag = resources.GetString("tdbgLista.PropBag");
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(4, 14);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(128, 23);
            this.btnCarregar.TabIndex = 502;
            this.btnCarregar.Text = "Carregar Grid";
            this.btnCarregar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(4, 41);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(128, 23);
            this.btnInserir.TabIndex = 503;
            this.btnInserir.Text = "Inserir Individualmente";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnNotificar
            // 
            this.btnNotificar.Location = new System.Drawing.Point(164, 14);
            this.btnNotificar.Name = "btnNotificar";
            this.btnNotificar.Size = new System.Drawing.Size(128, 23);
            this.btnNotificar.TabIndex = 504;
            this.btnNotificar.Text = "Carregar Notificações";
            this.btnNotificar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Location = new System.Drawing.Point(4, 270);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 23);
            this.btnLimpar.TabIndex = 505;
            this.btnLimpar.Text = "Limpar Grid";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // IntegracaoTechDevView_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnNotificar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.tdbgLista);
            this.Name = "IntegracaoTechDevView_ListView";
            this.Size = new System.Drawing.Size(555, 314);
            ((System.ComponentModel.ISupportInitialize)(this.tdbgLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid tdbgLista;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnNotificar;
        private System.Windows.Forms.Button btnLimpar;
    }
}
