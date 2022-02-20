using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models.Dto
{
    public class UserDto : LoginDto
    {
        public UserDto()
        {

        }

        public UserDto(User user, Role role)
        {
            Id = user.Id;
            Role = role.Name;   
            Email = user.Email;
        }

        public string Id { get; set; }
        public string Role { get; set; }
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
