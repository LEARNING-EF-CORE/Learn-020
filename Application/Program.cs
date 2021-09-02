namespace Application
{
	public class Program : object
	{
		public Program() : base()
		{
		}

		public static void Main()
		{
			Learn_0100.Class3 obj1 = new Learn_0100.Class3();
			Learn_0100.Class3 obj2 = obj1;

			Learn_0100.Class1 obj3 = obj1; // Up Casting!!!
			Learn_0100.Class1 obj4 = new Learn_0100.Class1();

			Learn_0200.Interface1 interface1 = new Learn_0200.Class1(); // Up Casting

			//Learn_0300.IVehicle vehicle =
			//	Learn_0300.VehicleFactory.GetVehicle(money: 100);

			Learn_0300.IVehicle vehicle =
				Learn_0300.VehicleFactory.GetVehicle(money: 2000);

			System.Console.WriteLine(vehicle.MaxSpeed);

			//Logging.LogManager logManager = new Logging.LogManager();
			//logManager.Log("Hello, World!");

			//Logging.LogManager logManager = new Logging.LogManager();
			////logManager.LogToDatabase("Hello, World!");
			//logManager.LogToFile("Hello, World!");

			////Logging.ILogger logger = new Logging.LogToFile();
			////Logging.ILogger logger = new Logging.LogToDatabase();
			////Logging.ILogger logger = new Learn_0400.LogBySms();

			//Logging.LogManager logManager = new Logging.LogManager(logger: logger);
			//logManager.Log("Hello, World!");

			Logging.ILogger logger = new Logging.LogToFile();
			Logging.LogManager logManager = new Logging.LogManager(logger: logger);
			logManager.Log("Hello, World!");
			logManager.Logger = new Logging.LogToDatabase();
			logManager.Log("Hello, World!");
			logManager.Logger = new Learn_0400.LogBySms();
			logManager.Log("Hello, World!");
			logManager.Logger = new Logging.LogToFile();
			logManager.Log("Hello, World!");
		}
	}
}
