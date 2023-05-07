using Microsoft.AspNetCore.Identity;
using Parcial3_GuerraCastroDuban.DAL.Entities;

namespace Parcial3_GuerraCastroDuban.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);
        Task<IdentityResult> AddUserAsync(User user, string password);
        Task CheckRoleAsync(string roleName);
        Task AddUserToRoleAsync(User user, string roleName);
        Task<bool> IsUserInRoleAsync(User user, string roleName);
    }
}
