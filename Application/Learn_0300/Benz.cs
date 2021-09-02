namespace Application.Learn_0300
{
	public class Benz : object, IVehicle
	{
		public Benz() : base()
		{
			MaxSpeed = 250;
		}

		public int Speed { get; set; }

		public int MaxSpeed { get; set; }

		public void Move()
		{
			System.Console.Write("I'm moving...");
		}
	}
}
