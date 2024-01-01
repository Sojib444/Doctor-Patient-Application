using Microsoft.AspNetCore.Identity;

namespace Telemedicine.Domain.Doctors
{
    public class Doctor : IdentityUser
    {
        public string  Name { get; set; }
        public string  DesingNation { get; set; }
    }
}
