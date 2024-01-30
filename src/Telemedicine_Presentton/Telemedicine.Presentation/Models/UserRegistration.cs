using System.ComponentModel.DataAnnotations;

namespace SignalRSample.Models
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public int AccountType { get; set; }
    }
}
