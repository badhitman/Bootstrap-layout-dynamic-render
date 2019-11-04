////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navbar
{
    public class NavbarNav : ViewComponent
    {
        public IViewComponentResult Invoke(NavbarNavManager SetObjectManager)
        {
            SetObjectManager.AddCSS("navbar-nav");
            return View(SetObjectManager);
        }
    }
}
