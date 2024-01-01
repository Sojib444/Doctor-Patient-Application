namespace Telemedicine.Domain.UnitofWork
{
    public interface IUnitofWork : IDisposable
    {
        Task SaveChangeAsync();
    }
}
