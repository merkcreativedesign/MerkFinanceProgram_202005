using System.Collections.Generic;
using MerkDataBaseBusinessLogicProject;

namespace MVCBusinessLogicLibrary.Viewers
{
	public interface ICashBoxInOutTransactionViewer : IViewer
	{
		object CashBoxTransactionType_P_ID { get; set; }
		object TransactionAmount { get; set; }
		object TranscationSerial { get; set; }
		object Description { get; set; }
		object TranscationDate { get; set; }
		List<CashBoxInOutTransaction> CashBoxInOutTransactionsList { get; set; }
	}
}
