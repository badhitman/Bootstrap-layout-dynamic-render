////////////////////////////////////////////////
// https://github.com/badhitman
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

        public NavItemManager AddNavItem(string id_dom, string header, string href)
        {
            NavItemManager navItem = new NavItemManager(id_dom) { Header = header, Href = href };
            Childs.Add(navItem);
            return navItem;
        }
    }
}
