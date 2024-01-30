using AutoMapper;
using Telemedicine.Application.Dtos;
using Telemedicine.Domain.Doctors;
using Telemedicine.Domain.UnitofWork;

namespace Telemedicine.Application.Services.DoctorServices
{
    public class UserServcies : IUserServices
    {
        private readonly IApplicationUnitofWork unitofWork;
        private readonly IMapper mapper;

        public UserServcies(IApplicationUnitofWork unitofWork, IMapper mapper)
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

        public async Task<UserDto> GetUser(string userId)
        {
            var users = await unitofWork.DoctorRepository.GetListAsync();

            var user = users.Where(x => x.Id == userId).FirstOrDefault();

            return mapper.Map<UserDto>(user);
        }

        public async Task<List<UserDto>> AllUsers()
        {
            var users = await unitofWork.DoctorRepository.GetListAsync();

            return (List<UserDto>)mapper.Map<ICollection<UserDto>>(users);          
        }
    }
}
