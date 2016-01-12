using System.Threading.Tasks;
using Abp.Application.Services;
using MTK.JanitorHelper.Roles.Dto;

namespace MTK.JanitorHelper.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
