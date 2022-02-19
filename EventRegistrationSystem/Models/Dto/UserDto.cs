using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models.Dto
{
    public class UserDto
    {
        public UserDto()
        {

        }

        public string Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public List<string> Roles { get; set; }
    }
}
