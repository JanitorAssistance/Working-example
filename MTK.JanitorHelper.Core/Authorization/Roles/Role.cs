using Abp.Authorization.Roles;
using MTK.JanitorHelper.MultiTenancy;
using MTK.JanitorHelper.Users;

namespace MTK.JanitorHelper.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}