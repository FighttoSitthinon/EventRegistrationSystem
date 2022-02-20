using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models.Dto
{
    public class UserDto : LoginDto
    {
        public UserDto()
        {

        }

        public string Id { get; set; }
        public List<string> Roles { get; set; }
    }

    public class LoginDto
    {
        public LoginDto()
        {

        }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
