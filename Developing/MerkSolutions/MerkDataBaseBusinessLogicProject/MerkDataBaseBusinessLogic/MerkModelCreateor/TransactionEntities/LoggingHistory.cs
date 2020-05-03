using System;
using System.Collections.Generic;
using System.Linq;
using MerkDataBaseBusinessLogicProject;
using MerkDataBaseBusinessLogicProject.EntitiesOperationsBusinessLogicLibrary;
using MerkDataBaseBusinessLogicProject.MerkDataBaseBusinessLogic.MerkModelCreateor.DBCommon;

namespace MerkDataBaseBusinessLogicProject
{
	public partial class LoggingHistory : DBCommon, IDBCommon
	{
		MerkFinanceEntities _context;
		private static List<LoggingHistory> _items;
		public static List<LoggingHistory> ItemsList = new List<LoggingHistory>();

		#region ColumnNames

		public static String Serial_ColumnaName
		{
			get { return "Serial"; }
		}

		#endregion

		public override bool LoadFromDB
		{
			get { return false; }
		}

		public override DBCommonEntitiesType TableType
		{
			get { return DBCommonEntitiesType.TransactionsEntities; }
		}

		public override bool LoadItemsList()
		{
			ItemsList.Clear();

			ItemsList = DBContext_External.LoggingHistories.ToList();
			return true;
		}

		public int TableIdentityID
		{
			get { return (int)DB_TableIdentity.LoggingHistory; }
		}

		public List<string> ChildrenItemsList
		{
			get
			{
				List<string> list = new List<string>();
				list.Add("LoggingHistoryDetail");
				return list;
			}
		}

		public string EntityName
		{
			get { return "LoggingHistory"; }
		}

		public IDBCommon GetSpecificEntity(MerkFinanceEntities context, int id)
		{
			return context.LoggingHistories.FirstOrDefault(item => item.ID.Equals(id));
		}
	}
}
