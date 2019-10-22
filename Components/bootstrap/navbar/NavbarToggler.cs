////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navbar
{
    public class NavbarToggler : ViewComponent
    {
        public IViewComponentResult Invoke(NavbarTogglerManager navbarToggler)
        {
            return View(navbarToggler);
        }
    }
}
