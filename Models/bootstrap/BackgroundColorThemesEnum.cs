////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Models.bootstrap
{
    /// <summary>
    /// Background color
    /// 
    /// Similar to the contextual text color classes, easily set the background of an element to any contextual class.
    /// Anchor components will darken on hover, just like the text classes.
    /// Background utilities do not set color, so in some cases you’ll want to use .text-* utilities.
    /// </summary>
    public enum BackgroundColorThemesEnum
    {
        NULL,
        primary,
        secondary,
        success,
        danger,
        warning,
        info,
        light,
        dark,
        white,
        transparent
    }
}