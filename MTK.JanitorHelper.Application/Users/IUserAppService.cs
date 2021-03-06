using System.Threading.Tasks;
using Abp.Application.Services;
using MTK.JanitorHelper.Users.Dto;

namespace MTK.JanitorHelper.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}