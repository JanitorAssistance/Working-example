using Abp.Application.Navigation;
using Abp.Localization;

namespace MTK.JanitorHelper.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class JanitorHelperNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", JanitorHelperConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", JanitorHelperConsts.LocalizationSourceName),
                        url: "#/about",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Data",
                        new LocalizableString("Data", JanitorHelperConsts.LocalizationSourceName),
                        url: "#/data",
                        icon: "fa fa-university"
                        )
                        .AddItem(
                            new MenuItemDefinition(
                            "Customers",
                            new LocalizableString("Customers", JanitorHelperConsts.LocalizationSourceName),
                            url: "#/data/customers"
                            ))
                        .AddItem(
                            new MenuItemDefinition(
                            "Housing",
                            new LocalizableString("Housing", JanitorHelperConsts.LocalizationSourceName),
                            url: "#/data/housing"
                            ))

                        );
        }
    }
}
