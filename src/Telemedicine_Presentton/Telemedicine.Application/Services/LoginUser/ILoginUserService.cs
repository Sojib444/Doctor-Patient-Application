using Telemedicine.Domain.AddLoginUser;

namespace Telemedicine.Application.Services.LoginUsers
{
    public interface ILoginUserService
    {
        Task AddAsync(LoginUser loginUser);
        Task RemoveAsync(string userName);
        Task<LoginUser> GetAsync(Guid Id);
        Task<ICollection<LoginUser>> GetAllAsync();
    }
}
