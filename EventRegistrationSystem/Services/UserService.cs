using EventRegistrationSystem.BusinessLogics;
using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Models.Dto;
using EventRegistrationSystem.Repositories;
using EventRegistrationSystem.Repositories.IRepositories;
using System.Text;
using System.Text.RegularExpressions;

namespace EventRegistrationSystem.Services.IServices
{
    public class UserService: IUserService
    {
        public static User User = new User();

        public readonly IUserRepository userRepository;
        public readonly IUserRoleRepository userRoleRepository;
        private readonly IConfiguration configuration;

        public UserService(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.userRepository = new UserRepository(dbContext);
            this.userRoleRepository = new UserRoleRepository(dbContext);
            this.configuration = configuration;
        }

        public User GetById(string Id)
        {
            var user = userRepository.Get(Id);

            return user;
        }

        public string Login(LoginDto model)
        {
            var user = userRepository.GetByEmail(model.Email);
            if (user == null) return string.Empty;

            byte[] plainText = Encoding.ASCII.GetBytes(model.Password);

            PasswordManagement passwordManagement = new PasswordManagement();
            var HashPassword = passwordManagement.GenerateSaltedHash(plainText, user.PasswordSalt);

            var IsSamePassword = passwordManagement.CompareByteArrays(HashPassword, user.PasswordHash);
            if(!IsSamePassword) return string.Empty;

            var roles = userRoleRepository.ListRolesByUserId(user.Id).ToList();

            UserDto userDto = new UserDto(user, roles);

            // generate JWT
            UserManagement userManagement = new UserManagement(configuration);
            var token = userManagement.GenerateToken(userDto);

            return token;
        }

        public string Register(LoginDto model)
        {
            bool IsUserExisted = userRepository.IsUserExisted(model.Email);
            if (IsUserExisted) return string.Empty;

            string saltText = Guid.NewGuid().ToString().Replace("-", "");
            byte[] plainText = Encoding.ASCII.GetBytes(model.Password);
            byte[] salt = Encoding.ASCII.GetBytes(saltText);

            PasswordManagement  passwordManagement = new PasswordManagement();
            var saltHash = passwordManagement.GenerateSaltedHash(plainText, salt);

            User user = new User()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                Email = model.Email.ToLower(),
                PasswordSalt = salt,
                PasswordHash = saltHash,
                Status = (int)Status.Active
            };

            userRepository.Create(user);
            userRepository.Save();

            return user.Id;
        }
    }
}
