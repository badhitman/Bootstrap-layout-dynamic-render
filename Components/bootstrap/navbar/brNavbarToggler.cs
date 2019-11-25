////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brNavbarToggler : ViewComponent
    {
        public IViewComponentResult Invoke(bsNavbarToggler SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
