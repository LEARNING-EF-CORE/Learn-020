namespace Application.Learn_0300
{
	public static class VehicleFactory
	{
		//public static Benz GetVehicle(int money)
		//{
		//	Benz benz = new Benz();

		//	return benz;
		//}

		//public static Pride GetVehicle(int money)
		//{
		//	Pride pride = new Pride();

		//	return pride;
		//}

		public static IVehicle GetVehicle(int money)
		{
			if(money < 1000)
			{
				Pride pride = new Pride();

				return pride;
			}
			else
			{
				Benz benz = new Benz();

				return benz;
			}
		}
	}
}
