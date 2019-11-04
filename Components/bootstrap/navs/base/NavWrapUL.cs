////////////////////////////////////////////////
// MIT License. https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navs
{
    public class NavWrapUL : ViewComponent
    {
        public IViewComponentResult Invoke(AbstractCoreNavManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
