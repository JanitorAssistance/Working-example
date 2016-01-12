using Abp.Web.Mvc.Views;

namespace MTK.JanitorHelper.Web.Views
{
    public abstract class JanitorHelperWebViewPageBase : JanitorHelperWebViewPageBase<dynamic>
    {

    }

    public abstract class JanitorHelperWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected JanitorHelperWebViewPageBase()
        {
            LocalizationSourceName = JanitorHelperConsts.LocalizationSourceName;
        }
    }
}