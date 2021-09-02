namespace Logging
{
	public class LogToDatabase : object, ILogger
	{
		public LogToDatabase() : base()
		{
		}

		public void Log(string message)
		{
			System.Console.WriteLine($"Database Logged The Message: [{ message }]");
		}
	}
}
