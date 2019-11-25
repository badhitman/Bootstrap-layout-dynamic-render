////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brNavbarNav : ViewComponent
    {
        public IViewComponentResult Invoke(bsNavbarNav SetObjectManager)
        {
            SetObjectManager.AddCSS("navbar-nav");
            return View(SetObjectManager);
        }
    }
}
