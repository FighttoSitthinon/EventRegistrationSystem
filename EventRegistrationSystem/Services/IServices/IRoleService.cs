using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Services.IServices
{
    public interface IRoleService
    {
        string Create(string roleName);
        string AddRole(string roleId, string UserName);
        Role Find(string roleName);
        List<Role> GetAll();
    }
}
