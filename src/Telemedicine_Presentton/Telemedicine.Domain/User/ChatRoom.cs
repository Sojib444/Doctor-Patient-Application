using System.ComponentModel.DataAnnotations;

namespace Telemedicine.Domain.Users
{
    public class ChatRoom
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
