////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navs
{
    public class NavItemHtmlDomA : ViewComponent
    {
        public IViewComponentResult Invoke(NavItemModel SetNavItem)
        {
            SetNavItem.AddCSS("nav-link");
            if (SetNavItem.IsActive)
                SetNavItem.AddCSS("active");

            if (SetNavItem.ChildsCount > 0)
            {
                SetNavItem.AddCSS("dropdown-toggle");
                SetNavItem.SetAttribute("data-toggle", "dropdown");
                SetNavItem.SetAttribute("role", "button");
                SetNavItem.SetAttribute("aria-haspopup", "true");
                SetNavItem.SetAttribute("aria-expanded", "false");
            }
            if (SetNavItem.IsDisabled)
            {
                SetNavItem.AddCSS(" disabled");
                SetNavItem.Tabindex = -1;
                SetNavItem.SetAttribute("aria-disabled", "true");
            }
            return View(SetNavItem);
        }
    }
}
