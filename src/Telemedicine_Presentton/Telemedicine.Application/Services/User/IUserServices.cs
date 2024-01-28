using Telemedicine.Application.Dtos;

namespace Telemedicine.Application.Services.DoctorServices
{
    public interface IUserServices
    {
        Task AddDoctor(UserDto doctor);
        Task<UserDto> GetUser(string userId);
        Task<List<UserDto>> AllUsers();
    }
}
