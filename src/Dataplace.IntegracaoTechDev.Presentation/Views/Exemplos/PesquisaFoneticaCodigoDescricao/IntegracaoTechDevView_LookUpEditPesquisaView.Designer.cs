﻿namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.LookUpEdit
{
    partial class IntegracaoTechDevView_LookUpEditPesquisaView
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
            this.luePesquisa = new dpLibrary05.Infrastructure.Controls.DPLookUpEdit();
            this.SuspendLayout();
            // 
            // luePesquisa
            // 
            this.luePesquisa.Active = false;
            this.luePesquisa.ControlHandlesSearchExecution = true;
            this.luePesquisa.DP_DataField = null;
            this.luePesquisa.DP_FilterMemo = false;
            this.luePesquisa.DP_SearchMethodFilter = null;
            this.luePesquisa.DP_ShowCaption = true;
            this.luePesquisa.FindMode = false;
            this.luePesquisa.InterfaceField = null;
            this.luePesquisa.IsReadonly = false;
            this.luePesquisa.Location = new System.Drawing.Point(23, 33);
            this.luePesquisa.Name = "luePesquisa";
            this.luePesquisa.SearchObject = null;
            this.luePesquisa.SettingValue = false;
            this.luePesquisa.Size = new System.Drawing.Size(460, 40);
            this.luePesquisa.TabIndex = 3;
            this.luePesquisa.Value = null;
            // 
            // IntegracaoTechDevView_LookUpEditPesquisaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.luePesquisa);
            this.Name = "IntegracaoTechDevView_LookUpEditPesquisaView";
            this.Size = new System.Drawing.Size(511, 109);
            this.ResumeLayout(false);

        }

        #endregion

        private dpLibrary05.Infrastructure.Controls.DPLookUpEdit luePesquisa;
    }
}
