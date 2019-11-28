////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrH : ViewComponent
    {
        public IViewComponentResult Invoke(hsH SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
