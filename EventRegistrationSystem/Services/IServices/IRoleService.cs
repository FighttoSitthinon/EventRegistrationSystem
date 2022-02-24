using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Services.IServices
{
    public interface IRoleService
    {
        string Create(string roleName);
        Role Find(string roleName);
        List<Role> GetAll();
    }
}
