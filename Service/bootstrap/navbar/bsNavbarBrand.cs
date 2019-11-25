////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class bsNavbarBrand : ahsDom
    {
        /// <summary>
        /// Позиционирование Brand внутри Navbar. "Внешнее размещение" слева или спарва от предполагаемого "navbar-toggler". Либо первым элементом внутри предполагаемого "collapse.navbar-collapse"
        /// </summary>
        public bmNavbarBrandPositionsEnum NavbarBrandPosition { get; set; } = bmNavbarBrandPositionsEnum.Left;

        /// <summary>
        /// The .navbar-brand can be applied to most elements, but an anchor works best as some elements might require utility classes or custom styles.
        /// </summary>
        public bmBrandNavItem NavbarBrandDom { get; set; }

        public override string ViewComponentName => nameof(brNavbarBrand);
    }
}
