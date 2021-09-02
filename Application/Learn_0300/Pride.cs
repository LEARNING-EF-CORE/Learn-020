namespace Application.Learn_0300
{
	public class Pride : object, IVehicle
	{
		public Pride() : base()
		{
			MaxSpeed = 150;
		}

		public int Speed { get; set; }

		public int MaxSpeed { get; set; }

		public void Move()
		{
			System.Console.Write("I'm moving...");
		}
	}
}
