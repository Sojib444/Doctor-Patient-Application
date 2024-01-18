using Telemedicine.Domain.AddLoginUser;
using Telemedicine.Domain.UnitofWork;

namespace Telemedicine.Application.Services.LoginUsers
{
    public class LoginUserService : ILoginUserService
    {
        private readonly IApplicationUnitofWork unitofWork;

        public LoginUserService(IApplicationUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        public async Task AddAsync(LoginUser loginUser)
        {
           await unitofWork.LoginRepository.CreatAsync(loginUser);
           await unitofWork.SaveChangeAsync();
           unitofWork.Dispose();
        }

        public async Task<ICollection<LoginUser>> GetAllAsync()
        {
           return await unitofWork.LoginRepository.GetListAsync();
        }

        public async Task<LoginUser> GetAsync(Guid Id)
        {
            return await unitofWork.LoginRepository.GetAsync(Id);
        }

        public async Task RemoveAsync(string userName)
        {
            var loginUser = await unitofWork.LoginRepository.GetListAsync();

            foreach(var item in  loginUser)
            {
                if(item.UserName == userName)
                {
                    await unitofWork.LoginRepository.DeleteAsync(item.Id);

                    await unitofWork.SaveChangeAsync();
                    unitofWork.Dispose();

                    break;
                }
            }            
        }
    }
}
