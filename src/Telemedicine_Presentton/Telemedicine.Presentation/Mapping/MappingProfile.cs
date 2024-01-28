using AutoMapper;
using Telemedicine.Application.Dtos;
using Telemedicine.Domain.Doctors;
using Telemedicine.Presentation.Models;

namespace Telemedicine.Presentation.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserRegistration, UserDto>().ReverseMap();
        }
    }
}
