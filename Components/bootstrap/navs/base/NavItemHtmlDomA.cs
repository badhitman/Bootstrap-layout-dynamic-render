////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navs
{
    public class NavItemHtmlDomA : ViewComponent
    {
        public IViewComponentResult Invoke(NavItemManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
