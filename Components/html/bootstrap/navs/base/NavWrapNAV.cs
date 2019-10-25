////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navs
{
    public class NavWrapNAV : ViewComponent
    {
        public IViewComponentResult Invoke(AbstractCoreNavManager SetObjectManager)
        {
            if (SetObjectManager is NavJavaScriptBehaviorManager)
                return View("Wrap", SetObjectManager);
            else
                return View(SetObjectManager);

        }
    }
}
