using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MerkDataBaseBusinessLogicProject.MerkDataBaseBusinessLogic.MerkModelCreateor.DBCommon;

namespace MerkDataBaseBusinessLogicProject
{
	public partial class GetFinanceDailyTransaction_SearchCriteria_Result : DBCommon, IDBCommon
	{
		public static List<GetFinanceDailyTransaction_SearchCriteria_Result> GetItemsList(object amountMin, object amountMax,
			object fromDate, object toDate, object isOnDuty, object userID)
		{
			return DBContext_External.GetFinanceDailyTransaction_SearchCriteria((double?) amountMin,
					(double?) amountMax, (DateTime?) fromDate, (DateTime?) toDate, (bool?) isOnDuty, (int?) userID)
				.ToList();
		}
	}
}
