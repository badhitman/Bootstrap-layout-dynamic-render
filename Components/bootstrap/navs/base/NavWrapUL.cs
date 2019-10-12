////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navs
{
    public class NavWrapUL : ViewComponent
    {
        public IViewComponentResult Invoke(AbstractNavManager navManager, bool SetPillsTheme)
        {
            ViewBag.IsPillsTheme = SetPillsTheme;
            return View(navManager);
        }
    }
}
