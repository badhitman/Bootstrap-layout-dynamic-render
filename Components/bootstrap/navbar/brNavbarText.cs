////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brNavbarText: ViewComponent
    {
        public IViewComponentResult Invoke(bsNavbarText SetObjectManager)
        {
            SetObjectManager.AddCSS("navbar-text");
            return View(SetObjectManager);
        }
    }
}
