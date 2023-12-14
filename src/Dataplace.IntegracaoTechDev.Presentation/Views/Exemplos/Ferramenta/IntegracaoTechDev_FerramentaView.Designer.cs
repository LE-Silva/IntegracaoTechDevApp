namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Ferramenta
{
    partial class IntegracaoTechDev_FerramentaView
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
            this.chkParametro1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkParametro1
            // 
            this.chkParametro1.AutoSize = true;
            this.chkParametro1.Location = new System.Drawing.Point(24, 20);
            this.chkParametro1.Name = "chkParametro1";
            this.chkParametro1.Size = new System.Drawing.Size(74, 17);
            this.chkParametro1.TabIndex = 501;
            this.chkParametro1.Text = "Parâmetro";
            this.chkParametro1.UseVisualStyleBackColor = true;
            // 
            // IntegracaoTechDev_FerramentaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkParametro1);
            this.Name = "IntegracaoTechDev_FerramentaView";
            this.Controls.SetChildIndex(this.chkParametro1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkParametro1;
    }
}
