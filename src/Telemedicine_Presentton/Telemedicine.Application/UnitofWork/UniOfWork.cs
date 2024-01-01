using Microsoft.EntityFrameworkCore;
using Telemedicine.Domain.UnitofWork;

namespace Telemedicine.Application.UnitofWork
{
    public class UniOfWork : IUnitofWork
    {
        private readonly DbContext dbContext;

        public UniOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task SaveChangeAsync()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
