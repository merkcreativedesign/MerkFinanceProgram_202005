using System.Windows.Forms;
using ApplicationConfiguration;
using CommonControlLibrary;
using MerkDataBaseBusinessLogicProject;
using MerkDataBaseBusinessLogicProject.EntitiesOperationsBusinessLogicLibrary;

namespace CommonUserControls.InvoiceViewers.MarketInvoice
{
	public partial class ChooseCashBox_UC : UserControl
	{
		private CashBox_cu SelectedRow { get; set; }
		private CashBoxTransactionContainer _cashBoxTransactionContainer;

		public ChooseCashBox_UC()
		{
			InitializeComponent();

			CommonViewsActions.LoadXMLFromString(layoutControl1, Resources.LocalizedRes.lyt_ChooseCashBox);
			CommonViewsActions.SetupGridControl(gridControl1, Resources.LocalizedRes.grd_ChooseCashBox, true);
			CommonViewsActions.SetupSyle(this);

			gridControl1.DataSource =
				FinancialBusinessLogicLibrary.GetOrganizationMachineCashBoxes(ApplicationStaticConfiguration
					.OrganizationMachine);
		}

		private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			var rowObject = CommonViewsActions.GetSelectedRowObject(gridView1);
			if (rowObject is CashBox_cu)
			{
				SelectedRow = ((CashBox_cu)rowObject);
				btnAccept_Click(null, null);
			}
		}

		private void gridControl1_MouseUp(object sender, MouseEventArgs e)
		{
			var rowObject = CommonViewsActions.GetSelectedRowObject(gridView1);
			if (rowObject is CashBox_cu)
				SelectedRow = ((CashBox_cu) rowObject);
		}

		private void btnAccept_Click(object sender, System.EventArgs e)
		{
			if (SelectedRow != null)
			{
				DialogResult result = MessageBox.Show("هل تريد إختيار " + SelectedRow.CashBoxFullName + "?", "الخزينة",
					MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1,
					MessageBoxOptions.RightAlign);
				if(result != DialogResult.Yes)
					return;
				ApplicationStaticConfiguration.ActiveCashBox = SelectedRow;
				CommonViewsActions.ShowUserControl(ref _cashBoxTransactionContainer, this);
			}

			if (ParentForm != null)
				ParentForm.Close();
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			if (ParentForm != null)
				ParentForm.Close();
		}

	}
}
