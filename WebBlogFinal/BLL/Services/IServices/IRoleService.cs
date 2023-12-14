using System.Data;
using WebBlogFinal.BLL.ViewModels.Roles;
using WebBlogFinal.DAL.Models;

namespace WebBlogFinal.BLL.Services.IServices
{
    public interface IRoleService
    {
        Task<Guid> CreateRole(RoleCreateViewModel model);

        Task EditRole(RoleEditViewModel model);

        Task RemoveRole(Guid id);

        Task<List<Role>> GetRoles();

        Task<Role?> GetRole(Guid id);
    }
}