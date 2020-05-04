using System;
using System.Collections.Generic;
using System.Linq;
using MerkDataBaseBusinessLogicProject.EntitiesOperationsBusinessLogicLibrary;
using MerkDataBaseBusinessLogicProject.MerkDataBaseBusinessLogic.MerkModelCreateor.DBCommon;

namespace MerkDataBaseBusinessLogicProject
{
	public partial class FinanceDailyTransaction : DBCommon, IDBCommon
	{
		MerkFinanceEntities _context;
		private static List<FinanceDailyTransaction> _items;
		public static List<FinanceDailyTransaction> ItemsList = new List<FinanceDailyTransaction>();

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

			ItemsList = DBContext_External.FinanceDailyTransactions.ToList();
			return true;
		}

		public int TableIdentityID
		{
			get { return (int)DB_TableIdentity.FinanceDailyTransaction; }
		}

		public List<string> ChildrenItemsList
		{
			get
			{
				List<string> list = new List<string>();
				list.Add("FinanceDailyTransactionDetail");
				return list;
			}
		}

		public string EntityName
		{
			get { return "FinanceDailyTransaction"; }
		}

		public IDBCommon GetSpecificEntity(MerkFinanceEntities context, int id)
		{
			return context.FinanceDailyTransactions.FirstOrDefault(item => item.ID.Equals(id));
		}

		public string DailyTransactionTypeName
		{
			get
			{
				DailyTransactionType_p type = DailyTransactionType_p.ItemsList.Find(item =>
					Convert.ToInt32(item.ID).Equals(Convert.ToInt32(DailyTransactionType_P_ID)));
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
	}
}
