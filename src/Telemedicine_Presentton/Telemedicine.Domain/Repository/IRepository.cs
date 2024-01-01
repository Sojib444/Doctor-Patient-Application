namespace Telemedicine.Domain.Repository
{
    public interface IRepository<T> where T : class
    {
        Task CreatAsync(T entity);
        Task<T> GetAsync(Guid id);
        Task<ICollection<T>> GetListAsync();
    }
}
