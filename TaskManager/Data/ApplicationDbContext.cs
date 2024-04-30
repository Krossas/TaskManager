using Microsoft.EntityFrameworkCore;
using TaskManager.Model;

namespace TaskManager.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<MyTask> MyTasks { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<MyTask>().HasData(
				new MyTask()
				{
					Id = 1,
					Description = "Test 01",
					IsDone = false,
					Order = 1
				},
				new MyTask()
				{
					Id = 2,
					Description = "Test 02",
					IsDone = false,
					Order = 2
				},
				new MyTask()
				{
					Id = 3,
					Description = "Test 03",
					IsDone = true,
					Order = 3
				},
				new MyTask()
				{
					Id = 4,
					Description = "Test 04",
					IsDone = false,
					Order = 4
				});
		}
	}
}
