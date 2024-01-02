using Microsoft.AspNetCore.Identity;

namespace Telemedicine.Domain.Doctors
{
    public class User : IdentityUser
    {
        public string  Name { get; set; }
        public int Doctor {  get; set; }
        public int AccoutType { get; set; } // 1 for Doctor // 2 for patient
    }
}
