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
            return View(SetNavItem);
        }
    }
}
