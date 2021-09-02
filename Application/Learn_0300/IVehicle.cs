namespace Application.Learn_0300
{
	public interface IVehicle
	{
		void Move();

		int Speed { get; set; }

		int MaxSpeed { get; set; }
	}
}
