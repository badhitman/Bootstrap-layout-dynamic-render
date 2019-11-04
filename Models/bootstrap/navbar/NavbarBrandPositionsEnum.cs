////////////////////////////////////////////////
// MIT License. https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Models.bootstrap.navbar
{
    public enum NavbarBrandPositioningEnum
    {
        /// <summary>
        /// NavbarBrand слева от navbar-toggler
        /// </summary>
        Left,

        /// <summary>
        /// NavbarBrand справа от navbar-toggler
        /// </summary>
        Right,

        /// <summary>
        /// NavbarBrand будет размещён внутри скрываемой области: <div class="collapse navbar-collapse" id="navbarTogglerDemo01">
        /// </summary>
        Hides
    }
}
