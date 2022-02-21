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
        public UserService(ApplicationDbContext dbContext)
        {
            this.userRepository = new UserRepository(dbContext);
        }

        public User GetById(string Id)
        {
            var user = userRepository.Get(Id);

            return user;
        }

        public string Login(LoginDto model)
        {
            var user = userRepository.GetByEmail(model.Email);
            if (user == null) return null;

            byte[] plainText = Encoding.ASCII.GetBytes(model.Password);

            PasswordManagement passwordManagement = new PasswordManagement();
            var HashPassword = passwordManagement.GenerateSaltedHash(plainText, user.PasswordSalt);

            var IsSamePassword = passwordManagement.CompareByteArrays(HashPassword, user.PasswordHash);
            if(!IsSamePassword) return null;

            UserDto userDto = new UserDto(user, new Role());
            // generate JWT
            UserManagement userManagement = new UserManagement();
            var token = userManagement.GenerateToken(userDto);

            return token;
        }

        public string Register(LoginDto model)
        {
            /*
                At least one upper case English letter, (?=.*?[A-Z])
                At least one lower case English letter, (?=.*?[a-z])
                At least one digit, (?=.*?[0-9])
                At least one special character, (?=.*?[#?!@$%^&*-])
                Minimum eight in length .{8,} (with the anchors)
            */
            string strRegex = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(model.Password)) return null;

            bool IsUserExisted = userRepository.IsUserExisted(model.Email);
            if (IsUserExisted) return null;

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
