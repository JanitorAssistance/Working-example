using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using MTK.JanitorHelper.EntityFramework;

namespace MTK.JanitorHelper
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(JanitorHelperCoreModule))]
    public class JanitorHelperDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
