using Telemedicine.Application.Dtos;

namespace Telemedicine.Application.Services.DoctorServices
{
    public interface IUserServices
    {
        Task AddDoctor(UserDto doctor);
        Task<UserDto> GetDcotr(Guid doctorId);
        Task<List<UserDto>> AllUsers();
    }
}
