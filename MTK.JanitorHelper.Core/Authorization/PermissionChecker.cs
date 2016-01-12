using Abp.Authorization;
using MTK.JanitorHelper.Authorization.Roles;
using MTK.JanitorHelper.MultiTenancy;
using MTK.JanitorHelper.Users;

namespace MTK.JanitorHelper.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
