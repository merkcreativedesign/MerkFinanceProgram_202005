using System;
using System.Windows.Forms;
using ApplicationConfiguration;
using MerkDataBaseBusinessLogicProject;
using MerkDataBaseBusinessLogicProject.EntitiesOperationsBusinessLogicLibrary;
using MVCBusinessLogicLibrary.BaseViewers;
using MVCBusinessLogicLibrary.MVCFactories;
using Application = DevExpress.XtraRichEdit.API.Word.Application;

namespace CommonUserControls.InvoiceViewers.MarketInvoice
{
	public partial class CashBoxTransactionContainer : UserControl
	{
		private DailyTransactions_UC dailyTransactions;

		public CashBoxTransactionContainer()
		{
			InitializeComponent();

			if (ApplicationStaticConfiguration.ActiveCashBox == null)
			{
				ChooseCashBox_UC chooseCashBox = new ChooseCashBox_UC();
				PopupBaseForm.ShowAsPopup(chooseCashBox, this);
			}

			SetCashBoxDetails();
		}

		private void btnDailyRecords_Click(object sender, EventArgs e)
		{
			if (ApplicationStaticConfiguration.ActiveCashBox == null)
			{
				ChooseCashBox_UC chooseCashBox = new ChooseCashBox_UC();
				PopupBaseForm.ShowAsPopup(chooseCashBox, this);
			}

			SetCashBoxDetails();

			if (ApplicationStaticConfiguration.ActiveCashBox != null)
				BaseController<CashBoxInOutTransaction>.ShowEditorControl(ref dailyTransactions,
					this,
					null,
					null,
					EditorContainerType.Regular,
					ViewerName.CashBoxInOutTrasactionViewer,
					DB_CommonTransactionType.CreateNew,
					"المعـامـــــلات اليـوميـــــــة",
					true);

			SetCashBoxDetails();
		}

		private void btnAcceptCashFromAnotherCahsBox_Click(object sender, EventArgs e)
		{

		}

		private void btnTransferCashToAnotherCashBox_Click(object sender, EventArgs e)
		{

		}

		private void btnStartCashBoxBalance_Click(object sender, EventArgs e)
		{

		}

		private void btnReturnCashBoxBalanceToMainCashBox_Click(object sender, EventArgs e)
		{

		}

		private void SetCashBoxDetails()
		{
			if (ApplicationStaticConfiguration.ActiveCashBox != null)
			{
				txtCashBoxName.Text = ApplicationConfiguration.ApplicationStaticConfiguration.ActiveCashBox
					.CashBoxFullName;
				DateTime date = DateTime.Now;
				string year = date.Year.ToString();
				string month = date.Month.ToString();
				string day = date.Day.ToString();
				string dateStr = "";
				if (Convert.ToInt32(day) >= 1 && Convert.ToInt32(day) <= 9)
					dateStr += "0" + day;
				else
					dateStr += day;
				if (Convert.ToInt32(month) >= 1 && Convert.ToInt32(month) <= 9)
					dateStr += " - 0" + month;
				else
					dateStr += " - " + month;
				dateStr += " - " + year;
				dtDate.Text = dateStr;
				spnTotalDebit.EditValue = FinancialBusinessLogicLibrary
					.GetCashBoxBalance(ApplicationStaticConfiguration.ActiveCashBox,
						FinancialBusinessLogicLibrary.CashBoxBalanceType.AllDebitOnly).ToString();
				spnTotalCredit.EditValue = FinancialBusinessLogicLibrary
					.GetCashBoxBalance(ApplicationStaticConfiguration.ActiveCashBox,
						FinancialBusinessLogicLibrary.CashBoxBalanceType.AllCreditOnly).ToString();
				spnTotalNet.EditValue =
					(FinancialBusinessLogicLibrary.GetCashBoxBalance(ApplicationStaticConfiguration.ActiveCashBox,
						 FinancialBusinessLogicLibrary.CashBoxBalanceType.AllDebitOnly) -
					 FinancialBusinessLogicLibrary.GetCashBoxBalance(ApplicationStaticConfiguration.ActiveCashBox,
						 FinancialBusinessLogicLibrary.CashBoxBalanceType.AllCreditOnly));
			}
			else
			{
				txtCashBoxName.EditValue = 0;
				dtDate.EditValue = 0;
				spnTotalDebit.EditValue = 0;
				spnTotalDebit.EditValue = 0;
				spnTotalNet.EditValue = 0;
			}
		}
	}
}
