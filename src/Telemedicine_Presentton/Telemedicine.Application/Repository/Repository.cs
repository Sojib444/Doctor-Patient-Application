using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.Repository;

namespace Telemedicine.Application.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext dbContext;
        private DbSet<T> set;

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            set = dbContext.Set<T>();
        }
        public async Task CreatAsync(T entity)
        {
            await set.AddAsync(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await set.FindAsync(id);

            if (entity != null)
                set.Remove(entity);
        }

        public async Task<T> GetAsync(Guid id)
        {
            var entity = await set.FindAsync(id);

            if (entity != null)
                return entity;
            throw new Exception("Id not found");
        }

        public async Task<ICollection<T>> GetListAsync()
        {
            return await set.ToListAsync();
        }
    }
}
