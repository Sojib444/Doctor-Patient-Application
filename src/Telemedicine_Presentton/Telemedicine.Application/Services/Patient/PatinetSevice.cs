using AutoMapper;
using Telemedicine.Application.Dtos;
using Telemedicine.Application.Services.Patientservices;
using Telemedicine.Domain.Patients;
using Telemedicine.Domain.UnitofWork;

namespace Telemedicine.Application.Services.PatientServiecs
{
    public class PatinetSevice : IPatientServices
    {
        private readonly IApplicationUnitofWork unitofWork;
        private readonly IMapper mapper;

        public PatinetSevice(IApplicationUnitofWork unitofWork, IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.mapper = mapper;
        }
        public async Task AddPatient(PatientDto patientDto)
        {
            var patietEntity = mapper.Map<Patient>(patientDto);
            await unitofWork.PatientRepository.CreatAsync(patietEntity);

            await unitofWork.SaveChangeAsync();
            unitofWork.Dispose();
        }
    }
}
