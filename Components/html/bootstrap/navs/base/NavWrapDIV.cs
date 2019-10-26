////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navs
{
    public class NavWrapDIV : ViewComponent
    {
        public IViewComponentResult Invoke(AbstractCoreNavManager SetObjectManager)
        {
            SetObjectManager.ChildsAddCSS("nav-item");
            return View(SetObjectManager);
        }
    }
}
