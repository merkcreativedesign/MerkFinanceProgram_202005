using System.Windows.Forms;
using CommonUserControls.SettingsViewers.FinanceDailyTransaction;
using CommonUserControls.SettingsViewers.FinanceDailyTransactionViewers;
using MerkDataBaseBusinessLogicProject;
using MerkDataBaseBusinessLogicProject.EntitiesOperationsBusinessLogicLibrary;
using MVCBusinessLogicLibrary.BaseViewers;
using MVCBusinessLogicLibrary.MVCFactories;

namespace CommonUserControls.MerkDesignWork
{
	public partial class MerkFinanceParentMenu : UserControl
	{
		private FinanceDailyTransaction_EditorViewer _financialDailyTransactionEditorViewer;
		private FinanceDailyTransaction_SearchViewer _financialDailyTransactionSearchViewer;

		public MerkFinanceParentMenu()
		{
			InitializeComponent();
		}

		private void btnDailyTransactions_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
		{
			BaseController<FinanceDailyTransaction>.ShowControl(ref _financialDailyTransactionEditorViewer,
				ref _financialDailyTransactionSearchViewer, panelControl1, EditorContainerType.Settings,
				ViewerName.FinanceDailyTransaction_Viewer, DB_CommonTransactionType.CreateNew,
				"المعامـــــلات اليـوميـــــة", AbstractViewerType.SearchViewer, true);
		}
	}
}
