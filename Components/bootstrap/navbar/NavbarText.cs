////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navbar
{
    public class NavbarText: ViewComponent
    {
        public IViewComponentResult Invoke(NavbarTextManager SetObjectManager)
        {
            SetObjectManager.AddCSS("navbar-text");
            return View(SetObjectManager);
        }
    }
}
