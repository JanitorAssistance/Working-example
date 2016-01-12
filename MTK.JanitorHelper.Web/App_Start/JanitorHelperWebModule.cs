using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Modules;
using Abp.Web.Mvc;
using Abp.Zero.Configuration;
using MTK.JanitorHelper.Api;
using Abp.Localization;

namespace MTK.JanitorHelper.Web
{
    [DependsOn(
        typeof(JanitorHelperDataModule), 
        typeof(JanitorHelperApplicationModule), 
        typeof(JanitorHelperWebApiModule),
        typeof(AbpWebMvcModule))]
    public class JanitorHelperWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Add/remove languages for your application
            Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flag-england", true));
            //Enable database based localization
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<JanitorHelperNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
