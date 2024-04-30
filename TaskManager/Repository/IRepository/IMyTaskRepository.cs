using TaskManager.Model;

namespace TaskManager.Repository.IRepository
{
    public interface IMyTaskRepository
    {
        Task<IEnumerable<MyTask>> GetAllAsync();
        Task<MyTask> GetAsync(int id);
        Task<MyTask> GetAsync(string myTaskName);
        Task CreateAsync(MyTask myTask);
        Task UpdateAsync(MyTask myTask);
        Task RemoveAsync(MyTask myTask);
        Task SaveAsync();
    }
}
