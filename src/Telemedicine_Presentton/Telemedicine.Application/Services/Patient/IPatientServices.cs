

using Telemedicine.Application.Dtos;

namespace Telemedicine.Application.Services.Patientservices
{
    public interface IPatientServices
    {
        Task AddPatient(PatientDto patientDto);
    }
}
