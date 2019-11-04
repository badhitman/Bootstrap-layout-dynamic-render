////////////////////////////////////////////////
// MIT License. https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Models.bootstrap
{
    /// <summary>
    /// Change the horizontal alignment of your nav with flexbox utilities.
    /// By default, navs are left-aligned, but you can easily change them to center or right aligned
    /// </summary>
    public enum NavOrientationsEnum
    {
        /// <summary>
        /// default, navs are left-aligned
        /// </summary>
        HorizontallyLeftAligned,

        /// <summary>
        /// Centered with .justify-content-center
        /// </summary>
        HorizontallyCenterAligned,

        /// <summary>
        /// Right-aligned with .justify-content-end:
        /// </summary>
        HorizontallyRightAligned,

        /// <summary>
        /// To proportionately fill all available space with your .nav-items, use .nav-fill.
        /// Notice that all horizontal space is occupied, but not every nav item has the same width.
        /// </summary>
        HorizontallyFill,

        /// <summary>
        /// For equal-width elements, use .nav-justified.
        /// All horizontal space will be occupied by nav links, but unlike the .nav-fill above, every nav item will be the same width.
        /// </summary>
        HorizontallyJustified,

        /// <summary>
        /// Stack your navigation by changing the flex item direction with the .flex-column utility.
        /// </summary>
        Vertically
    }
}
