////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.bootstrap.navbar;
using BootstrapViewComponentsRazorLibrary.Models;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar
{
    public class NavbarNavManager : AbstractCoreNavManager
    {
        public NavbarNavWrappersEnum NavWrapper { get; set; } = NavbarNavWrappersEnum.ul;

        public override string ViewComponentName => "NavWrap" + NavWrapper.ToString().ToUpper();

        public NavItemModel AddNavItem(string id_dom, string header, string href)
        {
            NavItemModel navItem = new NavItemModel(id_dom) { Header = header, Href = href };
            Childs.Add(navItem);
            return navItem;
        }
    }
}
