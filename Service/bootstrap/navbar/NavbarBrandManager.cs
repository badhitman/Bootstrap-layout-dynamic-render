////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap.navbar;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar
{
    public class NavbarBrandManager : AbstractDomManager
    {
        /// <summary>
        /// Позиционирование Brand внутри Navbar
        /// </summary>
        public NavbarBrandPositioningEnum NavbarBrandPosition { get; set; } = NavbarBrandPositioningEnum.Left;

        /// <summary>
        /// The .navbar-brand can be applied to most elements, but an anchor works best as some elements might require utility classes or custom styles.
        /// </summary>
        public NavItemModel NavbarBrandDom { get; set; } = null;

        /// <summary>
        /// Adding images 30x30 px to the .navbar-brand will likely always require custom styles or utilities to properly size.
        /// Here are some examples to demonstrate.
        /// </summary>
        public string ImageNavbarBrandSrc { get; set; } = null;
    }
}
