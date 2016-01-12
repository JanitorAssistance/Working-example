using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using MTK.JanitorHelper.Authorization.Roles;
using MTK.JanitorHelper.Editions;
using MTK.JanitorHelper.Users;

namespace MTK.JanitorHelper.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}