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

        public override string ViewComponentName => nameof(NavbarNav);

        public void AddNavItem(NavItemModel navItem)
        {
            Childs.Add(navItem);
        }
    }
}
