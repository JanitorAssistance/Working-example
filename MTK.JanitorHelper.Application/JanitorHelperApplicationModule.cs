using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace MTK.JanitorHelper
{
    [DependsOn(typeof(JanitorHelperCoreModule), typeof(AbpAutoMapperModule))]
    public class JanitorHelperApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
