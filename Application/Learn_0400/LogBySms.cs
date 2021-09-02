namespace Application.Learn_0400
{
	public class LogBySms : object, Logging.ILogger
	{
		public LogBySms() : base()
		{
		}

		public void Log(string message)
		{
			System.Console.WriteLine($"SMS Logged The Message: [{ message }]");
		}
	}
}
