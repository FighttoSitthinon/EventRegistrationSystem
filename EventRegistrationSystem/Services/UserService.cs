using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models.Dto;
using EventRegistrationSystem.Repositories;
using EventRegistrationSystem.Repositories.IRepositories;

namespace EventRegistrationSystem.Services.IServices
{
    public class UserService: IUserService
    {
        public readonly IUserRepository userRepository;
        public UserService(ApplicationDbContext dbContext)
        {
            this.userRepository = new UserRepository(dbContext);
        }

        public string Login(LoginDto model)
        {
            throw new NotImplementedException();
        }

        public string Register(UserDto model)
        {
            throw new NotImplementedException();
        }
    }
}
