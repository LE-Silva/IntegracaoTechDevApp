using C1.Win.C1FlexGrid;
using Dataplace.Core.Comunications;
using Dataplace.Core.Domain.Localization.Messages.Extensions;
using Dataplace.Core.win.Views.Controllers;
using Dataplace.IntegracaoTechDev.Core.Application.Queries.Cupom;
using Dataplace.IntegracaoTechDev.Core.Application.ViewModels;
using dpLibrary05;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Dataplace.IntegracaoTechDev.Presentation.Views.Exemplos.Consulta
{
    public partial class IntegracaoTechDevView_ConsultaCupom : DPUserControl
    {
        #region Variáveis Globais
        const int ITEMSEG_ID = 5945;
        const string TABLE_NAME = "Cupom";

        private DataSet _dadosConsulta;
        private clsUserPreference _userPreferenceCupom;
        private string _filtroConsulta;

        private readonly IMediatorHandler _mediatorHandler;
        #endregion

        #region Propriedades
        public NamedFilterController _namedfiltercontroller { get; set; }
        #endregion

        #region Construtor
        public IntegracaoTechDevView_ConsultaCupom() : this(BootStrapper.Container.GetInstance<IMediatorHandler>())
        {
            InitializeComponent();
            SetComponents();

            dtCupom.Click += (object sender, EventArgs e) =>
            {
                if (dtpReport.IsSelected)
                    LoadReport();
            };
        }

        private IntegracaoTechDevView_ConsultaCupom(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        #endregion

        #region Controles
        private void SetComponents()
        {
            try
            {
                dtCupom.SelectedTab = dtpFiltros;

                //Monta botão de filtros nomeados
                _namedfiltercontroller = new NamedFilterController(
                    this,
                    dtpFiltros,
                    btnpreferencefilter,
                    btnok,
                    ITEMSEG_ID.ToString(),
                    mGenerico.strUserName_P,
                    mGenerico.strCdEmpresa_P,
                    mGenerico.strCdFilial_P
                    );

                //Seta variáveis ao grid de consulta que serão utilizados para ocultar colunas, memória, etc
                fgcCupom.strCdEmpresa_p = mGenerico.strCdEmpresa_P;
                fgcCupom.strCdFilial_p = mGenerico.strCdFilial_P;
                fgcCupom.strItemSeguranca_p = ITEMSEG_ID.ToString();
                fgcCupom.strUserName_p = mGenerico.strUserName_P;
                fgcCupom.strPassword_p = mGenerico.strPassword_SQL;
                fgcCupom.strDSN_p = mGenerico.strDSN_P;

                //Monta no menu de ferramentas as opções de Gravar/Apagar memória de colunas do grid
                _userPreferenceCupom = new clsUserPreference(
                    mGenerico.strUserName_P,
                    mGenerico.strPassword_SQL,
                    mGenerico.strDSN_P,
                    mGenerico.strCdEmpresa_P,
                    mGenerico.strCdFilial_P,
                    ITEMSEG_ID.ToString()
                    );
                _userPreferenceCupom.ChangeGrid += (bool bActivated, string strMsgReturn) =>
                {

                };
                _userPreferenceCupom.CriaBotaoFuncoesGrid(ref sbPrincipal, ref fgcCupom);

                dtpData.Date1.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                dtpData.Date2.Value = Convert.ToDateTime(DateTime.Now.AddDays(1).ToShortDateString()).AddSeconds(-1);
                dtpData.Date1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDateLongTime;
                dtpData.Date2.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDateLongTime;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageForm.Error("private void SetControls() - " + ex.Message);
            } 
        }
        #endregion

        #region Manipulação de Dados do Grid/FlexGrid
        private void LoadReport()
        {
            try
            {
                if (ecpFiltro.IsExpanded)
                {
                    if (Convert.ToDateTime(dtpData.Date1.Value) > Convert.ToDateTime(dtpData.Date2.Value))
                    {
                        ShowMessageOnControl(13017.ToMessage(), dtpData);
                        return;
                    }
                }

                if (JsonConvert.SerializeObject(GetFilter()).Equals(_filtroConsulta, StringComparison.CurrentCultureIgnoreCase))
                    return;
                _filtroConsulta = JsonConvert.SerializeObject(GetFilter());

                MontaDsGrid(ref _dadosConsulta);
                if (!PreencheDataSet(ref _dadosConsulta))
                    return;

                MontaFlexGrid(ref _dadosConsulta);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageForm.Error("private void LoadReport() - " + ex.Message);
            }
        }

        private void MontaDsGrid(ref DataSet grid)
        {
            try
            {
                grid = new DataSet();
                var table = new DataTable(TABLE_NAME);

                //Criando colunas no DataTable
                table.Columns.Add(nameof(ConsultaCupomViewModel.NumCupomECF), typeof(String));
                table.Columns.Add(nameof(ConsultaCupomViewModel.ECFSerie), typeof(String));
                table.Columns.Add(nameof(ConsultaCupomViewModel.DataCupom), typeof(DateTime));

                //Adicionando DataTable no DataSet
                grid.Tables.Add(table);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageForm.Error("private void LoadReport() - " + ex.Message);
            }
        }

        private void MontaCaptionGrid()
        {
            try
            {
                //Criando colunas no grid

                fgcCupom.SetHeaderGrid(nameof(ConsultaCupomViewModel.NumCupomECF), "Nº Cupom", 100);
                fgcCupom.SetHeaderGrid(nameof(ConsultaCupomViewModel.ECFSerie), "Equipamento", 100);
                fgcCupom.SetHeaderGrid(nameof(ConsultaCupomViewModel.DataCupom), "Data", 100);

                fgcCupom.SetColumns();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageForm.Error("private void MontaCaptionGrid() - " + ex.Message);
            }
        }

        private void MontaFlexGrid(ref DataSet grid)
        {
            try
            {
                //Designer do Grid
                fgcCupom.Grid.Cols.Fixed = 0;
                fgcCupom.Grid.AllowSorting = AllowSortingEnum.SingleColumn;
                fgcCupom.Grid.AllowMerging = AllowMergingEnum.Nodes;
                fgcCupom.Grid.AllowDragging = AllowDraggingEnum.Columns;
                fgcCupom.Grid.SelectionMode = SelectionModeEnum.Cell;
                fgcCupom.Grid.ExtendLastCol = false;
                fgcCupom.Grid.Tree.Style = TreeStyleFlags.Simple;
                fgcCupom.Grid.Tree.Column = 0;
                fgcCupom.Grid.Styles.Normal.Border.Style = BorderStyleEnum.Dotted;
                fgcCupom.Grid.Styles.Normal.Trimming = StringTrimming.EllipsisCharacter;
                fgcCupom.Grid.Styles.Search.BackColor = Color.LightYellow;
                fgcCupom.Grid.Styles.Alternate.BackColor = Color.FromArgb(222, 222, 222, 222);

                fgcCupom.PossuiRegistros = true;
                if (grid.Tables[TABLE_NAME].Rows.Count == 0)
                    fgcCupom.PossuiRegistros = false;

                fgcCupom.DataSourceDesconectado(grid.Tables[TABLE_NAME]);

                MontaCaptionGrid();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageForm.Error("private void MontaFlexGrid() - " + ex.Message);
            }
        }

        private bool PreencheDataSet(ref DataSet grid)
        {
            try
            {
                var result = _mediatorHandler.Query(GetFilter()).Result;

                foreach (var item in result)
                {
                    DataRow linha = grid.Tables[TABLE_NAME].Rows.Add();

                    linha[nameof(item.NumCupomECF)] = item.NumCupomECF;
                    linha[nameof(item.ECFSerie)] = item.ECFSerie;
                    linha[nameof(item.DataCupom)] = item.DataCupom;

                    linha.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageForm.Error("private bool PreencheDataSet() - " + ex.Message);
                return false;
            }

            return true;
        }

        private ConsultaCupomFilter GetFilter()
        {
            return new ConsultaCupomFilter(ecpFiltro.IsExpanded, ConsultaCupomFilterDataEnum.Cupom, Convert.ToDateTime(dtpData.Date1.Value), Convert.ToDateTime(dtpData.Date2.Value));
        }
        #endregion
    }
}
