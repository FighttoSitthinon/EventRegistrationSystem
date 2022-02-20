using EventRegistrationSystem.Models;
using EventRegistrationSystem.Models.Dto;

namespace EventRegistrationSystem.Services.IServices
{
    public interface IUserService
    {
        string Register(LoginDto model);
        string Login(LoginDto model);
        User GetById(string Id);
    }
}
