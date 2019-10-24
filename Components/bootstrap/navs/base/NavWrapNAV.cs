////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navs
{
    public class NavWrapNAV : ViewComponent
    {
        public IViewComponentResult Invoke(AbstractCoreNavManager navManager)
        {
            if (navManager is NavJavaScriptBehaviorManager)
                return View("Wrap", navManager);
            else
                return View(navManager);

        }
    }
}
