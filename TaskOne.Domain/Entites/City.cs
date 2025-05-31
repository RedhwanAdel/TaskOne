namespace TaskOne.Domain.Entites
{
	public class City
	{
		public Guid Id { get; set; }
		public required string Name { get; set; }
		public List<School> School { get; set; } = [];
	}
}
