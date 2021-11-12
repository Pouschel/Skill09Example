namespace Tierheim
{
	public class Cat
	{
		public string Name { get; set; } = "";
		public int Age { get; set; }
		public string Race { get; set; } = "";
		public bool Castrated { get; set; }

		public Cat()
		{
		}

		public override string ToString() => Name;

	}
}
