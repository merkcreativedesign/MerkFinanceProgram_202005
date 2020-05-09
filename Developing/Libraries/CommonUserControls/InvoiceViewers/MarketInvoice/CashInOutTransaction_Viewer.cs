using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ApplicationConfiguration;
using CommonControlLibrary;
using CommonUserControls.SettingsViewers.GeneralChartOfAccountTypeViewers;
using MerkDataBaseBusinessLogicProject;
using MerkDataBaseBusinessLogicProject.EntitiesOperationsBusinessLogicLibrary;
using MerkDataBaseBusinessLogicProject.MerkDataBaseBusinessLogic.MerkModelCreateor.DBCommon;
using MVCBusinessLogicLibrary.BaseViewers;
using MVCBusinessLogicLibrary.Controller;
using MVCBusinessLogicLibrary.MVCFactories;
using MVCBusinessLogicLibrary.Viewers;

namespace CommonUserControls.InvoiceViewers.MarketInvoice
{
	public partial class CashInOutTransaction_Viewer : 
		//UserControl
		CommonAbstractEditorViewer<CashBoxInOutTransaction>,
		ICashBoxInOutTransactionViewer, IViewerDataRelated
	{
		private List<CashBoxInOutTransaction> listToBeViewedOnly = new List<CashBoxInOutTransaction>();
		private CashBoxInOutTransaction SelectedRow { get; set; }
		private GeneralChartOfAccountType_EditorViewer _generalChartOfAccountTypeEditorViewer;

		public CashInOutTransaction_Viewer()
		{
			InitializeComponent();

			CommonViewsActions.LoadXMLFromString(layoutControl1,
				Resources.LocalizedRes.lyt_CashBoxInOutTransaction_EditorViewer);
			CommonViewsActions.SetupGridControl(grdCashBoxInOutTransactions,
				Resources.LocalizedRes.grd_CashBoxInOutTransaction_Viewer, true);
			CommonViewsActions.SetupSyle(this);
		}

		#region Overrides of CommonAbstractViewer<CashBoxInOutTransaction>

		public override IMVCController<CashBoxInOutTransaction> ViewerCollector { get; set; }

		public override object ViewerID
		{
			get { return (int)ViewerName.CashBoxInOutTrasactionViewer; }
		}

		public override string HeaderTitle
		{
			get { throw new NotImplementedException(); }
		}

		public override void FillControls()
		{
			CommonViewsActions.FillGridlookupEdit(lkeGeneralChartOfAccount, GeneralChartOfAccountType_cu.ItemsList);

			chkExpenses.Checked = true;
			dtInvoiceCreation.DateTime = DateTime.Now;
			spnAmount.EditValue = 0;
			txtDescription.Text = string.Empty;
			txtSerial.Text =
				listToBeViewedOnly != null && listToBeViewedOnly.Count > 0
					? FinancialBusinessLogicLibrary.GetNextCashBoxInOutTransactionSerial(FinancialBusinessLogicLibrary
						.SerialType
						.CashBoxTransactionInOutExpenses, listToBeViewedOnly)
					: FinancialBusinessLogicLibrary.GetNextCashBoxInOutTransactionSerial(FinancialBusinessLogicLibrary
						.SerialType
						.CashBoxTransactionInOutExpenses, CashBoxInOutTransaction.ItemsList);
			if (listToBeViewedOnly != null)
			{
				listToBeViewedOnly.Clear();
				foreach (CashBoxInOutTransaction cashBoxInOutTransaction in CashBoxInOutTransaction.ItemsList)
					cashBoxInOutTransaction.AddedType = AddedType.AlreadyExists;
				listToBeViewedOnly.AddRange(CashBoxInOutTransaction.ItemsList);
				grdCashBoxInOutTransactions.DataSource = listToBeViewedOnly;
			}

			spnAmount.SelectAll();
			spnAmount.Focus();
			spnAmount.RightToLeft = RightToLeft.No;
			txtCashBoxName.Text = ApplicationStaticConfiguration.ActiveCashBox.CashBoxFullName;
			txtNet.EditValue = (FinancialBusinessLogicLibrary.GetCashBoxBalance(
									ApplicationStaticConfiguration.ActiveCashBox,
									FinancialBusinessLogicLibrary.CashBoxBalanceType.AllDebitOnly) +
								FinancialBusinessLogicLibrary.GetCashBoxBalance(
									ApplicationStaticConfiguration.ActiveCashBox,
									FinancialBusinessLogicLibrary.CashBoxBalanceType.AllCreditOnly));
		}

		public override void ClearControls()
		{
			chkExpenses.Checked = true;
			txtSerial.Text =
				listToBeViewedOnly != null && listToBeViewedOnly.Count > 0
					? FinancialBusinessLogicLibrary.GetNextCashBoxInOutTransactionSerial(FinancialBusinessLogicLibrary
						.SerialType
						.CashBoxTransactionInOutExpenses, listToBeViewedOnly)
					: FinancialBusinessLogicLibrary.GetNextCashBoxInOutTransactionSerial(FinancialBusinessLogicLibrary
						.SerialType
						.CashBoxTransactionInOutExpenses, CashBoxInOutTransaction.ItemsList);
			dtInvoiceCreation.DateTime = DateTime.Now;
			spnAmount.EditValue = 0;
			txtDescription.Text = string.Empty;
			spnAmount.SelectAll();
			spnAmount.Focus();
		}

		#endregion

		#region Implementation of ICashBoxInOutTransactionViewer

		public object CashBoxTransactionType_P_ID
		{
			get
			{
				if (chkExpenses.Checked)
					return (int)DB_CashBoxTransactionType.ExpenseWithdraw;
				if (chkReverseExpenses.Checked)
					return (int)DB_CashBoxTransactionType.ReverseExpenseWithdraw;
				if (chkRevenue.Checked)
					return (int)DB_CashBoxTransactionType.RevenueDeposit;
				if (chkReverseRevenue.Checked)
					return (int)DB_CashBoxTransactionType.ReverseRevenueDeposit;
				return null;
			}
			set
			{
				switch ((DB_CashBoxTransactionType)value)
				{
					case DB_CashBoxTransactionType.ExpenseWithdraw:
						chkExpenses.Checked = true;
						break;
					case DB_CashBoxTransactionType.ReverseExpenseWithdraw:
						chkReverseExpenses.Checked = true;
						break;
					case DB_CashBoxTransactionType.RevenueDeposit:
						chkRevenue.Checked = true;
						break;
					case DB_CashBoxTransactionType.ReverseRevenueDeposit:
						chkReverseRevenue.Checked = true;
						break;
				}
			}
		}

		public object TransactionAmount
		{
			get { return spnAmount.EditValue; }
			set { spnAmount.EditValue = value; }
		}

		public object TranscationSerial
		{
			get { return txtSerial.EditValue; }
			set { txtSerial.EditValue = value; }
		}

		public object Description
		{
			get { return txtDescription.EditValue; }
			set { txtDescription.EditValue = value; }
		}

		public object TranscationDate
		{
			get { return dtInvoiceCreation.EditValue; }
			set { dtInvoiceCreation.EditValue = value; }
		}

		public List<CashBoxInOutTransaction> CashBoxInOutTransactionsList { get; set; }

		#endregion

		#region Implementation of IViewerDataRelated

		public object ViewerDataRelated { get; set; }

		#endregion

		private void btnAddToList_Click(object sender, EventArgs e)
		{
			if (spnAmount.EditValue == null || Math.Abs(Convert.ToDouble(spnAmount.EditValue)) < 0.0001)
				return;

			if (CashBoxInOutTransactionsList == null)
				CashBoxInOutTransactionsList = new List<CashBoxInOutTransaction>();

			CashBoxInOutTransaction cashBoxInOutTransaction = DBCommon.CreateNewDBEntity<CashBoxInOutTransaction>();
			if (CashBoxTransactionType_P_ID != null)
				cashBoxInOutTransaction.CashBoxTransactionType_P_ID = Convert.ToInt32(CashBoxTransactionType_P_ID);
			if (TransactionAmount != null)
				cashBoxInOutTransaction.TransactionAmount = chkExpenses.Checked || chkReverseRevenue.Checked
					? Convert.ToDouble(TransactionAmount) * -1
					: Convert.ToDouble(TransactionAmount);
			if (TranscationSerial != null)
				cashBoxInOutTransaction.TranscationSerial = TranscationSerial.ToString();
			if (Description != null)
				cashBoxInOutTransaction.Description = Description.ToString();
			if (TranscationDate != null)
				cashBoxInOutTransaction.TranscationDate = Convert.ToDateTime(TranscationDate);
			if (ApplicationStaticConfiguration.ActiveCashBox != null)
				cashBoxInOutTransaction.CashBox_CU_ID = ApplicationStaticConfiguration.ActiveCashBox.ID;

			cashBoxInOutTransaction.AddedType = AddedType.NewelyAdded;

			CashBoxInOutTransactionsList.Add(cashBoxInOutTransaction);
			listToBeViewedOnly.Clear();

			listToBeViewedOnly.AddRange(CashBoxInOutTransaction.ItemsList.FindAll(item =>
				!Convert.ToInt32(item.AddedType).Equals(Convert.ToInt32(AddedType.Removed))));
			listToBeViewedOnly.AddRange(CashBoxInOutTransactionsList.FindAll(item =>
				!Convert.ToInt32(item.AddedType).Equals(Convert.ToInt32(AddedType.Removed))));

			grdCashBoxInOutTransactions.DataSource = listToBeViewedOnly.OrderByDescending(item => item.TranscationDate);
			grdCashBoxInOutTransactions.RefreshDataSource();
			gridView7.SelectRow(-1);
			ClearControls();
		}

		private void btnRemoveFromList_Click(object sender, EventArgs e)
		{
			if (SelectedRow == null)
				return;

			CashBoxInOutTransaction tobeDeleted = null;
			foreach (CashBoxInOutTransaction cashBoxInOutTransaction in CashBoxInOutTransaction.ItemsList)
				if (SelectedRow.ID == cashBoxInOutTransaction.ID)
				{
					cashBoxInOutTransaction.AddedType = AddedType.Removed;
					cashBoxInOutTransaction.DBCommonTransactionType = DB_CommonTransactionType.DeleteExisting;
					break;
				}

			foreach (CashBoxInOutTransaction cashBoxInOutTransaction in CashBoxInOutTransactionsList)
				if (SelectedRow.TranscationSerial.Equals(cashBoxInOutTransaction.TranscationSerial))
				{
					cashBoxInOutTransaction.AddedType = AddedType.Removed;
					break;
				}

			listToBeViewedOnly.Clear();

			listToBeViewedOnly.AddRange(CashBoxInOutTransaction.ItemsList.FindAll(item =>
				!Convert.ToInt32(item.AddedType).Equals(Convert.ToInt32(AddedType.Removed))));
			listToBeViewedOnly.AddRange(CashBoxInOutTransactionsList.FindAll(item =>
				!Convert.ToInt32(item.AddedType).Equals(Convert.ToInt32(AddedType.Removed))));

			grdCashBoxInOutTransactions.DataSource = listToBeViewedOnly.OrderByDescending(item => item.TranscationDate);
			grdCashBoxInOutTransactions.RefreshDataSource();
			gridView7.SelectRow(-1);
			ClearControls();
		}

		private void grdCashBoxInOutTransactions_MouseUp(object sender, MouseEventArgs e)
		{
			var rowObject = CommonViewsActions.GetSelectedRowObject(gridView7);
			if (rowObject is CashBoxInOutTransaction)
				SelectedRow = ((CashBoxInOutTransaction)rowObject);
		}

		private void grdCashBoxInOutTransactions_DoubleClick(object sender, EventArgs e)
		{
			var rowObject = CommonViewsActions.GetSelectedRowObject(gridView7);
			if (rowObject is CashBoxInOutTransaction)
				SelectedRow = ((CashBoxInOutTransaction)rowObject);
		}

		private void chkExpenses_CheckedChanged(object sender, EventArgs e)
		{
			txtSerial.Text =
				FinancialBusinessLogicLibrary.GetNextCashBoxInOutTransactionSerial(FinancialBusinessLogicLibrary.SerialType
					.CashBoxTransactionInOutExpenses, listToBeViewedOnly);

			//List<>
		}

		private void chkReverseExpenses_CheckedChanged(object sender, EventArgs e)
		{
			txtSerial.Text =
				FinancialBusinessLogicLibrary.GetNextCashBoxInOutTransactionSerial(FinancialBusinessLogicLibrary.SerialType
					.CashBoxTransactionInOutExpenses, listToBeViewedOnly);
		}

		private void chkRevenue_CheckedChanged(object sender, EventArgs e)
		{
			txtSerial.Text =
				FinancialBusinessLogicLibrary.GetNextCashBoxInOutTransactionSerial(FinancialBusinessLogicLibrary.SerialType
					.CashBoxTransactionInOutDeposit, listToBeViewedOnly);
		}

		private void chkReverseRevenue_CheckedChanged(object sender, EventArgs e)
		{
			txtSerial.Text =
				FinancialBusinessLogicLibrary.GetNextCashBoxInOutTransactionSerial(FinancialBusinessLogicLibrary.SerialType
					.CashBoxTransactionInOutDeposit, listToBeViewedOnly);
		}

		private void DailyTransactions_UC_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
				btnAddToList_Click(null, null);
		}

		private void lkeAddgeneralGeneralChartOfAccount_Click(object sender, EventArgs e)
		{
			BaseController<Location_cu>.ShowEditorControl(ref _generalChartOfAccountTypeEditorViewer, this, null, null,
				EditorContainerType.Regular, ViewerName.GeneralChartOfAccountType_Viewer, DB_CommonTransactionType.CreateNew,
				"الحسـابــــات المـاليـــــة", true);
			CommonViewsActions.FillGridlookupEdit(lkeGeneralChartOfAccount, GeneralChartOfAccountType_cu.ItemsList);
		}
	}
}
