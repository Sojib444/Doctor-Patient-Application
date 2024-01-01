using Telemedicine.Application.Dtos;

namespace Telemedicine.Application.Services.DoctorServices
{
    public interface IDoctorServices
    {
        Task AddDoctor(DoctorDto doctor);
        Task<DoctorDto> GetDcotr(Guid doctorId);
        Task<List<DoctorDto>> GetDoctors();
    }
}
