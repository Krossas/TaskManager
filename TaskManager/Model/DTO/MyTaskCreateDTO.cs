namespace TaskManager.Model.DTO
{
    public class MyTaskCreateDTO
    {
		public string Description { get; set; }
		public int Order { get; set; }
		public bool IsDone { get; set; } = false;
	}
}
