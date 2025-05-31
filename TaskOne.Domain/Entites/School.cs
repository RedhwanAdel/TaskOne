namespace TaskOne.Domain.Entites
{
	public class School
	{
		public Guid Id { get; set; }
		public required string Name { get; set; }
		public Guid CityId { get; set; }
		public City City { get; set; } = null!;
	}
}
