using System;
using System.Collections.Generic;
using System.Linq;
using MerkDataBaseBusinessLogicProject.EntitiesOperationsBusinessLogicLibrary;
using MerkDataBaseBusinessLogicProject.MerkDataBaseBusinessLogic.MerkModelCreateor.DBCommon;

namespace MerkDataBaseBusinessLogicProject
{
	public enum AddedType
	{
		AlreadyExists = 1,
		NewelyAdded = 2,
		Removed = 3,
	}

	public partial class CashBoxInOutTransaction : DBCommon, IDBCommon
	{
		MerkFinanceEntities _context;
		private static List<CashBoxInOutTransaction> _items;
		public static List<CashBoxInOutTransaction> ItemsList = new List<CashBoxInOutTransaction>();

		#region ColumnNames

		public static String Serial_ColumnaName
		{
			get { return "Serial"; }
		}

		#endregion

		public override bool LoadFromDB
		{
			get { return true; }
		}

		public override DBCommonEntitiesType TableType
		{
			get { return DBCommonEntitiesType.CustomUserEntities; }
		}

		public override bool LoadItemsList()
		{
			ItemsList.Clear();

			ItemsList = DBContext_External.CashBoxInOutTransactions.OrderByDescending(item => item.TranscationDate).ToList();
			return true;
		}

		public int TableIdentityID
		{
			get { return (int)DB_TableIdentity.CashBoxInOutTransaction; }
		}

		public List<string> ChildrenItemsList
		{
			get
			{
				List<string> list = new List<string>();
				list.Add("CashBoxInOutTransactionDetail");
				return list;
			}
		}

		public string EntityName
		{
			get { return "CashBoxInOutTransaction"; }
		}

		public IDBCommon GetSpecificEntity(MerkFinanceEntities context, int id)
		{
			return context.CashBoxInOutTransactions.FirstOrDefault(item => item.ID.Equals(id));
		}

		public string CashBoxTransactionTypeName
		{
			get
			{
				CashBoxTransactionType_p type = CashBoxTransactionType_p.ItemsList.Find(item =>
					Convert.ToInt32(item.ID).Equals(Convert.ToInt32(CashBoxTransactionType_P_ID)));
				if (type != null)
					return type.Name_P;
				return null;
			}
		}

		public string UserName
		{
			get
			{
				User_cu user =
					User_cu.ItemsList.Find(item => Convert.ToInt32(item.ID).Equals(Convert.ToInt32(InsertedBy)));
				if (user != null)
					return user.FullName.ToString();
				return null;
			}
		}

		public string TranslatedAmount
		{
			get
			{
				if (Convert.ToInt32(CashBoxTransactionType_P_ID) == (int) DB_CashBoxTransactionType.ExpenseWithdraw ||
				    Convert.ToInt32(CashBoxTransactionType_P_ID) ==
				    (int) DB_CashBoxTransactionType.ReverseRevenueDeposit)
						return "( " + TransactionAmount + " )";
				return TransactionAmount.ToString();
			}
		}

		public string CashBoxName
		{
			get
			{
				if (CashBox_CU_ID == null)
					return "";
				CashBox_cu cashBox = CashBox_cu.ItemsList.Find(item =>
					Convert.ToInt32(item.ID).Equals(Convert.ToInt32(CashBox_CU_ID)));
				if (cashBox == null)
					return "";
				return cashBox.CashBoxFullName;
			}
		}

		public AddedType AddedType { get; set; }
	}
}
