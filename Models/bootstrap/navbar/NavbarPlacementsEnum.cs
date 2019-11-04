////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////

namespace BootstrapViewComponentsRazorLibrary.Models.bootstrap
{
    /// <summary>
    /// Navbar Placements
    /// 
    /// Use our position utilities to place navbars in non-static positions.Choose from fixed to the top, fixed to the bottom, or stickied to the top(scrolls with the page until it reaches the top, then stays there).
    /// Fixed navbars use position: fixed, meaning they’re pulled from the normal flow of the DOM and may require custom CSS(e.g., padding - top on the<body>) to prevent overlap with other elements.
    /// 
    /// Also note that.sticky - top uses position: sticky, which isn’t fully supported in every browser.
    /// </summary>
    public enum NavbarPlacementsEnum
    {
        Default,
        FixedTop,
        FixedBottom,
        StickyTop
    }
}
