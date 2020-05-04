namespace MVCBusinessLogicLibrary.Viewers
{
	public interface IFinanceDailyTransactionSearchViewer : IFinanceDailyTransactionViewer
	{
		object amountMin { get; set; }
		object amountMax { get; set; }
		object dateFrom { get; set; }
		object dateTo { get; set; }
		object isOnDuty { get; set; }
	}
}
