////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Models
{
    /// <summary>
    /// Типы внешних DOM для оборачивания "Bootstrap Navbar->Navs"
    /// </summary>
    public enum NavbarNavWrappersEnum
    {
        /// <summary>
        /// Формат ul->li->a списка
        /// </summary>
        ul,

        /// <summary>
        /// Формат div->a
        /// </summary>
        div
    }
}
