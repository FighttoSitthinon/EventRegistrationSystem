using EventRegistrationSystem.Models.Dto;

namespace EventRegistrationSystem.Services.IServices
{
    public interface IUserService
    {
        string Register(UserDto model);
        string Login(LoginDto model);
    }
}
