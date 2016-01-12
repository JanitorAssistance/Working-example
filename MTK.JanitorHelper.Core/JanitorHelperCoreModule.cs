using System.Reflection;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Localization.Sources;
using Abp.Localization.Sources.Xml;
using Abp.Modules;
using Abp.Zero;

namespace MTK.JanitorHelper
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class JanitorHelperCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Remove the following line to disable multi-tenancy.
            //Configuration.MultiTenancy.IsEnabled = true;

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    JanitorHelperConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        Assembly.GetExecutingAssembly(),
                        "MTK.JanitorHelper.Localization.Source"
                        )
                    )
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
