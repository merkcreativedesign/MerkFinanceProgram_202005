namespace MVCBusinessLogicLibrary.Viewers
{
	public interface IFinanceDailyTransactionViewer : IViewer
	{
		object DailyTransactionType { get; set; }
		object Amount { get; set; }
		object Date { get; set; }
		object Description { get; set; }
	}
}
