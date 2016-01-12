using Abp.Application.Features;
using MTK.JanitorHelper.Authorization.Roles;
using MTK.JanitorHelper.MultiTenancy;
using MTK.JanitorHelper.Users;

namespace MTK.JanitorHelper.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}