namespace Application.Learn_0200
{
	//public interface Interface3
	//public interface Interface3 : Interface1
	//public interface Interface3 : Interface2
	public interface Interface3 : Interface1, Interface2
	{
		void SomeFunction3();

		int SomeProperty3 { get; set; }
	}
}
