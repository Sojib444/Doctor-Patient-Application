using AutoMapper;
using Telemedicine.Application.Dtos;
using Telemedicine.Domain.Patients;

namespace Telemedicine.Presentation.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Patient,PatientDto>().ReverseMap();
            CreateMap<Patient,PatientDto>().ReverseMap();
        }
    }
}
