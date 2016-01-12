using Abp.MultiTenancy;
using MTK.JanitorHelper.Users;

namespace MTK.JanitorHelper.MultiTenancy
{
    public class Tenant : AbpTenant<Tenant, User>
    {

    }
}