using AutoMapper;
using Telemedicine.Application.Dtos;
using Telemedicine.Domain.Doctors;
using Telemedicine.Domain.UnitofWork;

namespace Telemedicine.Application.Services.DoctorServices
{
    public class DoctorServcies : IDoctorServices
    {
        private readonly IApplicationUnitofWork unitofWork;
        private readonly IMapper mapper;

        public DoctorServcies(IApplicationUnitofWork unitofWork, IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.mapper = mapper;
        }
        public async Task AddDoctor(DoctorDto doctor)
        {
            var doctorEntity = mapper.Map<User>(doctor);
            doctorEntity.PasswordHash = doctor.Password;
            await unitofWork.DoctorRepository.CreatAsync(doctorEntity);

            await unitofWork.SaveChangeAsync();
            unitofWork.Dispose();
        }

        public Task<DoctorDto> GetDcotr(Guid doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<List<DoctorDto>> GetDoctors()
        {
            throw new NotImplementedException();
        }
    }
}
