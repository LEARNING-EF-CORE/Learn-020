namespace Logging
{
	public class LogToFile : object, ILogger
	{
		public LogToFile() : base()
		{
		}

		public void Log(string message)
		{
			System.Console.WriteLine($"File Logged The Message: [{ message }]");
		}
	}
}
