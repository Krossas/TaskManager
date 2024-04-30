using System.ComponentModel.DataAnnotations;

namespace TaskManager.Model
{
	public class MyTask
	{
		[Key]
		public int Id { get; set; }
		public string? Description { get; set; }
		public int? Order { get; set; }
		public bool IsDone { get; set; }
	}
}
