using AutoMapper;
using Telemedicine.Application.Dtos;
using Telemedicine.Domain.Doctors;
using Telemedicine.Domain.UnitofWork;

namespace Telemedicine.Application.Services.DoctorServices
{
    public class UserrServcies : IUserServices
    {
        private readonly IApplicationUnitofWork unitofWork;
        private readonly IMapper mapper;

        public UserrServcies(IApplicationUnitofWork unitofWork, IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.mapper = mapper;
        }
        public async Task AddDoctor(UserDto doctor)
        {
            var doctorEntity = mapper.Map<User>(doctor);
            doctorEntity.PasswordHash = doctor.Password;
            await unitofWork.DoctorRepository.CreatAsync(doctorEntity);

            await unitofWork.SaveChangeAsync();
            unitofWork.Dispose();
        }

        public Task<UserDto> GetDcotr(Guid doctorId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserDto>> AllUsers()
        {
            var users = await unitofWork.DoctorRepository.GetListAsync();

            var UsersDto = (List<UserDto>)mapper.Map<ICollection<UserDto>>(users);

            return UsersDto;
        }
    }
}
