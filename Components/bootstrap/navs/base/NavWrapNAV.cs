////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navs
{
    public class NavWrapNAV : ViewComponent
    {
        public IViewComponentResult Invoke(AbstractNavManager navManager, bool SetPillsTheme)
        {
            if (SetPillsTheme)
                navManager.AddCSS("nav-pills");
            else if (navManager.IsTabsStyle)
                navManager.AddCSS("nav-tabs");

            if (navManager is NavJavaScriptBehaviorManager)
                navManager.SetAttribute("role", "tablist");

            if (navManager is NavJavaScriptBehaviorManager)
                return View("Wrap", navManager);
            else
                return View(navManager);

        }
    }
}
