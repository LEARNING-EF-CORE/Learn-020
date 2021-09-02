//namespace Logging
//{
//	public class LogManager : object
//	{
//		public LogManager() : base()
//		{
//		}

//		public void Log(string message)
//		{
//			System.Console.WriteLine($"Database Logged The Message: [{ message }]");
//		}
//	}
//}

//namespace Logging
//{
//	public class LogManager : object
//	{
//		public LogManager() : base()
//		{
//		}

//		/// <summary>
//		/// کار احمقانه
//		/// </summary>
//		/// <param name="message"></param>
//		public void Log(string message)
//		{
//			System.Console.WriteLine($"File Logged The Message: [{ message }]");
//		}
//	}
//}

//namespace Logging
//{
//	public class LogManager : object
//	{
//		public LogManager() : base()
//		{
//		}

//		public void LogToFile(string message)
//		{
//			System.Console.WriteLine($"File Logged The Message: [{ message }]");
//		}

//		public void LogToDatabase(string message)
//		{
//			System.Console.WriteLine($"Database Logged The Message: [{ message }]");
//		}
//	}
//}

namespace Logging
{
	public class LogManager : object
	{
		public LogManager(ILogger logger) : base()
		{
			Logger = logger;
		}

		public ILogger Logger { get; set; }

		public void Log(string message)
		{
			Logger.Log(message);
		}
	}
}

