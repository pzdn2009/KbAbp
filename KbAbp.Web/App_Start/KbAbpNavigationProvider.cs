using Abp.Application.Navigation;
using Abp.Localization;

namespace KbAbp.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class KbAbpNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition("Home", new LocalizableString("HomePage", KbAbpConsts.LocalizationSourceName), url: "#/", icon: "fa fa-home")
                )
                .AddItem(
                    new MenuItemDefinition(
                        "TaskManagement", new LocalizableString("TaskManagement", KbAbpConsts.LocalizationSourceName), icon: "fa fa-tasks")
                        .AddItem(new MenuItemDefinition("TaskList", new LocalizableString("TaskList", KbAbpConsts.LocalizationSourceName), url: "#/tasklist", icon: "fa fa-list"))
                        .AddItem(new MenuItemDefinition("NewTask", new LocalizableString("New", KbAbpConsts.LocalizationSourceName), url: "#/newtask", icon: "fa fa-plus"))
                )
                .AddItem(
                    new MenuItemDefinition(
                        "ProjectManagement", new LocalizableString("ProjectManagement", KbAbpConsts.LocalizationSourceName), icon: "fa fa-info")
                        .AddItem(new MenuItemDefinition("ProjectList", new LocalizableString("ProjectList", KbAbpConsts.LocalizationSourceName), url: "#/projectlist", icon: "fa fa-list"))
                        .AddItem(new MenuItemDefinition("NewProject", new LocalizableString("New", KbAbpConsts.LocalizationSourceName), url: "#/newproject", icon: "fa fa-plus"))
                )
                .AddItem(
                    new MenuItemDefinition(
                        "KBManagement", new LocalizableString("KBManagement", KbAbpConsts.LocalizationSourceName), icon: "fa fa-info")
                        .AddItem(new MenuItemDefinition("NewKbCategory", new LocalizableString("NewKbCategory", KbAbpConsts.LocalizationSourceName), url: "#/newkbcategory", icon: "fa fa-plus"))
                )
                .AddItem(
                    new MenuItemDefinition("About", new LocalizableString("About", KbAbpConsts.LocalizationSourceName), url: "#/about", icon: "fa fa-info")
                );
        }
    }
}
