using System;
using MVCBusinessLogicLibrary.BaseViewers;
using MVCBusinessLogicLibrary.Viewers;
using System.Windows.Forms;
using CommonControlLibrary;
using MerkDataBaseBusinessLogicProject;
using MVCBusinessLogicLibrary.MVCFactories;

namespace CommonUserControls.SettingsViewers.FinanceDailyTransaction
{
	public partial class FinanceDailyTransaction_SearchViewer : 
		//UserControl
		CommonAbstractSearchViewer<MerkDataBaseBusinessLogicProject.FinanceDailyTransaction>,
		IFinanceDailyTransactionViewer
	{
		public FinanceDailyTransaction_SearchViewer()
		{
			InitializeComponent();

			CommonViewsActions.LoadXMLFromString(layoutControl1,
				Resources.LocalizedRes.lyt_FinanceDailyTransaction_EditorViewer);
			CommonViewsActions.SetupSyle(this);
		}

		#region Overrides of CommonAbstractViewer<FinanceDailyTransaction>

		public override object ViewerID
		{
			get { return (int)ViewerName.FinanceDailyTransaction_Viewer; }
		}

		public override string HeaderTitle
		{
			get { return "المعاملات اليومية"; }
		}

		public override void FillControls()
		{
			CommonViewsActions.FillGridlookupEdit(lkeDailyTransactionType,
				MerkDataBaseBusinessLogicProject.FinanceDailyTransaction.ItemsList);
		}

		public override void ClearControls()
		{
			txtDescription.EditValue = null;
			lkeDailyTransactionType.EditValue = null;
			spnAmount.EditValue = null;
			dtDate.DateTime = DateTime.Now;
		}

		public override string GridXML
		{
			get { return Resources.LocalizedRes.grd_FinanceDailyTransaction_SearchViewer; }
		}

		#endregion

		#region Implementation of IFinanceDailyTransactionViewer

		public object DailyTransactionType
		{
			get { return lkeDailyTransactionType.EditValue; }
			set { lkeDailyTransactionType.EditValue = value; }
		}

		public object Amount
		{
			get { return spnAmount.EditValue; }
			set { spnAmount.EditValue = value; }
		}

		public object Date
		{
			get { return dtDate.EditValue; }
			set { dtDate.EditValue = value; }
		}

		public object Description
		{
			get { return txtDescription.EditValue; }
			set { txtDescription.EditValue = value; }
		}

		#endregion
	}
}
