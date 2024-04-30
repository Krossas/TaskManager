using TaskManager.Data;
using TaskManager.Model;
using TaskManager.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace TaskManager.Repository
{
	public class MyTaskRepository : IMyTaskRepository
	{
		public ApplicationDbContext _db;

		public MyTaskRepository(ApplicationDbContext db)
		{
			_db = db;
		}

		public async Task CreateAsync(MyTask myTask)
		{
			_db.Add(myTask);
		}

		public async Task<IEnumerable<MyTask>> GetAllAsync()
		{
			return await _db.MyTasks.ToListAsync();
		}

		public async Task<MyTask> GetAsync(int id)
		{
			return await _db.MyTasks.FirstOrDefaultAsync(u => u.Id == id);
		}

		public async Task<MyTask> GetAsync(string myTaskDescription)
		{
			return await _db.MyTasks.FirstOrDefaultAsync(u => u.Description.ToLower() == myTaskDescription.ToLower());
		}

		public async Task UpdateAsync(MyTask myTask)
		{
			_db.MyTasks.Update(myTask);
		}

		public async Task RemoveAsync(MyTask myTask)
		{
			_db.MyTasks.Remove(myTask);
		}

		public async Task SaveAsync()
		{
			await _db.SaveChangesAsync();
		}
	}
}
