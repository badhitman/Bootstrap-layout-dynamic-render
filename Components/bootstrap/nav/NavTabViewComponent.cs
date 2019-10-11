////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.nav
{
    public class NavTabViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(AbstractNavManager navManager)
        {
            return View(navManager);
        }
    }
}
