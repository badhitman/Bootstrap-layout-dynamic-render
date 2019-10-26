////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.bootstrap.navbar;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap.navbar;
using BootstrapViewComponentsRazorLibrary.Models.html.bootstrap.navbar;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar
{
    public class NavbarBrandManager : AbstractDomManager
    {
        /// <summary>
        /// Позиционирование Brand внутри Navbar. "Внешнее размещение" слева или спарва от предполагаемого "navbar-toggler". Либо первым элементом внутри предполагаемого "collapse.navbar-collapse"
        /// </summary>
        public NavbarBrandPositioningEnum NavbarBrandPosition { get; set; } = NavbarBrandPositioningEnum.Left;

        /// <summary>
        /// The .navbar-brand can be applied to most elements, but an anchor works best as some elements might require utility classes or custom styles.
        /// </summary>
        public BrandNavItemModel NavbarBrandDom { get; set; }

        public override string ViewComponentName => nameof(NavbarBrand);
    }
}
