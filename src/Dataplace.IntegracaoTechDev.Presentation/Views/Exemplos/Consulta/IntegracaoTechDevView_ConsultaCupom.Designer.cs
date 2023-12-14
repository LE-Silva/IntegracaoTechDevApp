using dpLibrary05;

namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Consulta
{
    partial class IntegracaoTechDevView_ConsultaCupom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntegracaoTechDevView_ConsultaCupom));
            this.dtCupom = new C1.Win.C1Command.C1DockingTab();
            this.dtpFiltros = new C1.Win.C1Command.C1DockingTabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dpTableLayoutPanel29 = new dpLibrary05.DPTableLayoutPanel(this.components);
            this.btnok = new C1.Win.C1Input.C1SplitButton();
            this.btnpreferencefilter = new C1.Win.C1Input.C1SplitButton();
            this.ecpFiltro = new dpLibrary05.Infrastructure.Controls.ExpandCollapsePanel.ExpandCollapsePanel();
            this.tlpPeriodoSelecao = new dpLibrary05.DPTableLayoutPanel(this.components);
            this.lblNumPedido = new dpLibrary05.Infrastructure.Controls.DPLabel();
            this.dtpData = new dpLibrary05.ucSymGen_ReferenceDtp();
            this.rbDataCupom = new dpLibrary05.Infrastructure.Controls.DPRadioButton();
            this.dtpReport = new C1.Win.C1Command.C1DockingTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pctreport = new System.Windows.Forms.PictureBox();
            this.tsFuncoes = new System.Windows.Forms.ToolStrip();
            this.sbPrincipal = new System.Windows.Forms.ToolStripSplitButton();
            this.fgcCupom = new dpLibrary05.FlexGroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtCupom)).BeginInit();
            this.dtCupom.SuspendLayout();
            this.dtpFiltros.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.dpTableLayoutPanel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnpreferencefilter)).BeginInit();
            this.ecpFiltro.SuspendLayout();
            this.tlpPeriodoSelecao.SuspendLayout();
            this.dtpReport.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctreport)).BeginInit();
            this.tsFuncoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgcCupom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgcCupom.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCupom
            // 
            this.dtCupom.Controls.Add(this.dtpFiltros);
            this.dtCupom.Controls.Add(this.dtpReport);
            this.dtCupom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtCupom.Location = new System.Drawing.Point(0, 0);
            this.dtCupom.Name = "dtCupom";
            this.dtCupom.SelectedIndex = 1;
            this.dtCupom.Size = new System.Drawing.Size(649, 372);
            this.dtCupom.TabIndex = 0;
            this.dtCupom.TabsSpacing = 5;
            // 
            // dtpFiltros
            // 
            this.dtpFiltros.Controls.Add(this.tableLayoutPanel3);
            this.dtpFiltros.Location = new System.Drawing.Point(1, 24);
            this.dtpFiltros.Name = "dtpFiltros";
            this.dtpFiltros.Size = new System.Drawing.Size(647, 347);
            this.dtpFiltros.TabIndex = 0;
            this.dtpFiltros.Text = "Filtros";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel3.Controls.Add(this.ecpFiltro, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dpTableLayoutPanel29, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(647, 347);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dpTableLayoutPanel29
            // 
            this.dpTableLayoutPanel29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dpTableLayoutPanel29.ColumnCount = 3;
            this.tableLayoutPanel3.SetColumnSpan(this.dpTableLayoutPanel29, 6);
            this.dpTableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dpTableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dpTableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dpTableLayoutPanel29.Controls.Add(this.btnok, 2, 0);
            this.dpTableLayoutPanel29.Controls.Add(this.btnpreferencefilter, 1, 0);
            this.dpTableLayoutPanel29.Location = new System.Drawing.Point(29, 316);
            this.dpTableLayoutPanel29.Name = "dpTableLayoutPanel29";
            this.dpTableLayoutPanel29.RowCount = 1;
            this.dpTableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dpTableLayoutPanel29.Size = new System.Drawing.Size(615, 28);
            this.dpTableLayoutPanel29.TabIndex = 3;
            // 
            // btnok
            // 
            this.btnok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnok.Location = new System.Drawing.Point(510, 3);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(102, 22);
            this.btnok.TabIndex = 1;
            this.btnok.Tag = "3484";
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            // 
            // btnpreferencefilter
            // 
            this.btnpreferencefilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpreferencefilter.Location = new System.Drawing.Point(402, 3);
            this.btnpreferencefilter.Name = "btnpreferencefilter";
            this.btnpreferencefilter.Size = new System.Drawing.Size(102, 22);
            this.btnpreferencefilter.TabIndex = 0;
            this.btnpreferencefilter.Tag = "3484";
            this.btnpreferencefilter.Text = "btnPreferenceFilter";
            this.btnpreferencefilter.UseVisualStyleBackColor = true;
            // 
            // ecpFiltro
            // 
            this.ecpFiltro.ButtonSize = dpLibrary05.Infrastructure.Controls.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.ecpFiltro.ButtonStyle = dpLibrary05.Infrastructure.Controls.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Checkbox;
            this.tableLayoutPanel3.SetColumnSpan(this.ecpFiltro, 5);
            this.ecpFiltro.Controls.Add(this.tlpPeriodoSelecao);
            this.ecpFiltro.ExpandedHeight = 122;
            this.ecpFiltro.GrowAsPercentage = false;
            this.ecpFiltro.IsExpanded = true;
            this.ecpFiltro.Location = new System.Drawing.Point(3, 3);
            this.ecpFiltro.Name = "ecpFiltro";
            this.tableLayoutPanel3.SetRowSpan(this.ecpFiltro, 3);
            this.ecpFiltro.Size = new System.Drawing.Size(494, 144);
            this.ecpFiltro.TabIndex = 4;
            this.ecpFiltro.Tag = "4137";
            this.ecpFiltro.Text = "Seleção";
            this.ecpFiltro.UseAnimation = false;
            // 
            // tlpPeriodoSelecao
            // 
            this.tlpPeriodoSelecao.ColumnCount = 6;
            this.tlpPeriodoSelecao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPeriodoSelecao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPeriodoSelecao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPeriodoSelecao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPeriodoSelecao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPeriodoSelecao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpPeriodoSelecao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPeriodoSelecao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPeriodoSelecao.Controls.Add(this.lblNumPedido, 0, 0);
            this.tlpPeriodoSelecao.Controls.Add(this.dtpData, 0, 1);
            this.tlpPeriodoSelecao.Controls.Add(this.rbDataCupom, 0, 2);
            this.tlpPeriodoSelecao.Location = new System.Drawing.Point(20, 36);
            this.tlpPeriodoSelecao.Name = "tlpPeriodoSelecao";
            this.tlpPeriodoSelecao.RowCount = 3;
            this.tlpPeriodoSelecao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpPeriodoSelecao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpPeriodoSelecao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPeriodoSelecao.Size = new System.Drawing.Size(388, 84);
            this.tlpPeriodoSelecao.TabIndex = 0;
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.Active = false;
            this.lblNumPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumPedido.AutoSize = true;
            this.tlpPeriodoSelecao.SetColumnSpan(this.lblNumPedido, 2);
            this.lblNumPedido.DP_DataField = null;
            this.lblNumPedido.DP_FilterMemo = false;
            this.lblNumPedido.FindMode = false;
            this.lblNumPedido.InterfaceField = null;
            this.lblNumPedido.IsReadonly = false;
            this.lblNumPedido.Location = new System.Drawing.Point(3, 9);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.SettingValue = false;
            this.lblNumPedido.Size = new System.Drawing.Size(102, 13);
            this.lblNumPedido.TabIndex = 0;
            this.lblNumPedido.Tag = "";
            this.lblNumPedido.Text = "Período de Seleção";
            // 
            // dtpData
            // 
            this.tlpPeriodoSelecao.SetColumnSpan(this.dtpData, 4);
            this.dtpData.Date1CustomFormat = dpLibrary05.ucSymGen_ReferenceDtp.CustomFormatEnum.FLong;
            this.dtpData.Date2CustomFormat = dpLibrary05.ucSymGen_ReferenceDtp.CustomFormatEnum.FLong;
            this.dtpData.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dtpData.DotNetContainer = false;
            this.dtpData.KeyPreview = false;
            this.dtpData.Label1Text = dpLibrary05.ucSymGen_ReferenceDtp.LabelTextEnum.TFrom;
            this.dtpData.Label2Text = dpLibrary05.ucSymGen_ReferenceDtp.LabelTextEnum.TTo;
            this.dtpData.Location = new System.Drawing.Point(3, 25);
            this.dtpData.Name = "dtpData";
            this.dtpData.OpenModal = false;
            this.dtpData.Parameters = ((System.Collections.Generic.IDictionary<string, object>)(resources.GetObject("dtpData.Parameters")));
            this.dtpData.Size = new System.Drawing.Size(378, 20);
            this.dtpData.TabIndex = 1;
            this.dtpData.TabOrderScheme = dpLibrary05.TabOrderManager.TabScheme.None;
            // 
            // rbDataCupom
            // 
            this.rbDataCupom.Active = false;
            this.rbDataCupom.AutoSize = true;
            this.rbDataCupom.Checked = true;
            this.rbDataCupom.DP_DataField = null;
            this.rbDataCupom.DP_FilterMemo = true;
            this.rbDataCupom.FindMode = false;
            this.rbDataCupom.InterfaceField = null;
            this.rbDataCupom.IsReadonly = false;
            this.rbDataCupom.Location = new System.Drawing.Point(3, 53);
            this.rbDataCupom.Name = "rbDataCupom";
            this.rbDataCupom.SettingValue = false;
            this.rbDataCupom.Size = new System.Drawing.Size(99, 17);
            this.rbDataCupom.TabIndex = 2;
            this.rbDataCupom.TabStop = true;
            this.rbDataCupom.Tag = "";
            this.rbDataCupom.Text = "Data do Cupom";
            this.rbDataCupom.UseVisualStyleBackColor = true;
            // 
            // dtpReport
            // 
            this.dtpReport.Controls.Add(this.tableLayoutPanel1);
            this.dtpReport.Location = new System.Drawing.Point(1, 24);
            this.dtpReport.Name = "dtpReport";
            this.dtpReport.Size = new System.Drawing.Size(647, 347);
            this.dtpReport.TabIndex = 1;
            this.dtpReport.Text = "Report";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fgcCupom, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(647, 347);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pctreport, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tsFuncoes, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 312);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(641, 32);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pctreport
            // 
            this.pctreport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pctreport.Image = ((System.Drawing.Image)(resources.GetObject("pctreport.Image")));
            this.pctreport.Location = new System.Drawing.Point(619, 14);
            this.pctreport.Name = "pctreport";
            this.pctreport.Size = new System.Drawing.Size(19, 15);
            this.pctreport.TabIndex = 2;
            this.pctreport.TabStop = false;
            this.pctreport.Visible = false;
            // 
            // tsFuncoes
            // 
            this.tsFuncoes.Dock = System.Windows.Forms.DockStyle.None;
            this.tsFuncoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbPrincipal});
            this.tsFuncoes.Location = new System.Drawing.Point(0, 0);
            this.tsFuncoes.Name = "tsFuncoes";
            this.tsFuncoes.Size = new System.Drawing.Size(79, 25);
            this.tsFuncoes.TabIndex = 3;
            this.tsFuncoes.Text = "toolStrip1";
            // 
            // sbPrincipal
            // 
            this.sbPrincipal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sbPrincipal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbPrincipal.Name = "sbPrincipal";
            this.sbPrincipal.Size = new System.Drawing.Size(67, 22);
            this.sbPrincipal.Text = "Funções";
            this.sbPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fgcCupom
            // 
            this.fgcCupom.alColumns = ((System.Collections.ArrayList)(resources.GetObject("fgcCupom.alColumns")));
            this.fgcCupom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgcCupom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fgcCupom.bColumnInsertIsGroup = false;
            this.fgcCupom.bGridColumnReorganize = false;
            this.fgcCupom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgcCupom.bRefreshGroups = "False";
            this.fgcCupom.C1FlexGridControl = this.fgcCupom.Grid;
            this.fgcCupom.ColsFrozen = 0;
            this.fgcCupom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.fgcCupom.Grid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns;
            this.fgcCupom.Grid.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Nodes;
            this.fgcCupom.Grid.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgcCupom.Grid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.MultiColumn;
            this.fgcCupom.Grid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.fgcCupom.Grid.ColumnInfo = resources.GetString("fgcCupom.Grid.ColumnInfo");
            this.fgcCupom.Grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fgcCupom.Grid.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.fgcCupom.Grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fgcCupom.Grid.Location = new System.Drawing.Point(0, 35);
            this.fgcCupom.Grid.Name = "";
            this.fgcCupom.Grid.Rows.DefaultSize = 19;
            this.fgcCupom.Grid.Rows.Fixed = 2;
            this.fgcCupom.Grid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgcCupom.Grid.ShowCursor = true;
            this.fgcCupom.Grid.Size = new System.Drawing.Size(639, 266);
            this.fgcCupom.Grid.StyleInfo = resources.GetString("fgcCupom.Grid.StyleInfo");
            this.fgcCupom.Grid.TabIndex = 0;
            this.fgcCupom.Grid.Tree.Column = 0;
            this.fgcCupom.Grid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom;
            this.fgcCupom.GroupMessage = "";
            this.fgcCupom.Image = null;
            this.fgcCupom.intIndexGroupInserted = -1;
            this.fgcCupom.Location = new System.Drawing.Point(3, 3);
            this.fgcCupom.Name = "fgcCupom";
            this.fgcCupom.oDestaqueGrid = null;
            this.fgcCupom.oHeaderGrid = null;
            this.fgcCupom.oTotalizaGrid = null;
            this.fgcCupom.PermiteOcultarExibirColunas = true;
            this.fgcCupom.PermiteOrdenacao = true;
            this.fgcCupom.PermiteOrdenacaoGrupo = true;
            this.fgcCupom.PossuiRegistros = true;
            this.fgcCupom.ShowGroups = true;
            this.fgcCupom.Size = new System.Drawing.Size(641, 303);
            this.fgcCupom.strCdEmpresa_p = null;
            this.fgcCupom.strCdFilial_p = null;
            this.fgcCupom.strDSN_p = null;
            this.fgcCupom.strItemSeguranca_p = null;
            this.fgcCupom.strPassword_p = null;
            this.fgcCupom.strUserName_p = null;
            this.fgcCupom.TabIndex = 1;
            this.fgcCupom.TabStop = false;
            // 
            // IntegracaoTechDevView_ConsultaCupom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtCupom);
            this.Name = "IntegracaoTechDevView_ConsultaCupom";
            this.Size = new System.Drawing.Size(649, 372);
            ((System.ComponentModel.ISupportInitialize)(this.dtCupom)).EndInit();
            this.dtCupom.ResumeLayout(false);
            this.dtpFiltros.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.dpTableLayoutPanel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnpreferencefilter)).EndInit();
            this.ecpFiltro.ResumeLayout(false);
            this.ecpFiltro.PerformLayout();
            this.tlpPeriodoSelecao.ResumeLayout(false);
            this.tlpPeriodoSelecao.PerformLayout();
            this.dtpReport.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctreport)).EndInit();
            this.tsFuncoes.ResumeLayout(false);
            this.tsFuncoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgcCupom.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgcCupom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Command.C1DockingTab dtCupom;
        private C1.Win.C1Command.C1DockingTabPage dtpFiltros;
        private C1.Win.C1Command.C1DockingTabPage dtpReport;
        public FlexGroupControl fgcCupom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.PictureBox pctreport;
        private System.Windows.Forms.ToolStrip tsFuncoes;
        private System.Windows.Forms.ToolStripSplitButton sbPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DPTableLayoutPanel dpTableLayoutPanel29;
        internal C1.Win.C1Input.C1SplitButton btnok;
        internal C1.Win.C1Input.C1SplitButton btnpreferencefilter;
        private dpLibrary05.Infrastructure.Controls.ExpandCollapsePanel.ExpandCollapsePanel ecpFiltro;
        private DPTableLayoutPanel tlpPeriodoSelecao;
        private dpLibrary05.Infrastructure.Controls.DPLabel lblNumPedido;
        internal ucSymGen_ReferenceDtp dtpData;
        private dpLibrary05.Infrastructure.Controls.DPRadioButton rbDataCupom;
    }
}
