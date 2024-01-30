using Microsoft.AspNetCore.Identity;

namespace SignalRSample.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public int Doctor { get; set; }
        public int AccountType { get; set; } // 1 for Doctor // 2 for patient
    }
}
