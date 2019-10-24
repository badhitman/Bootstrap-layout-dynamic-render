////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navbar
{
    public class NavbarText: ViewComponent
    {
        public IViewComponentResult Invoke(NavbarTextManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
