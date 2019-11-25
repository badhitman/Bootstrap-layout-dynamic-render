////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrDiv : ViewComponent
    {
        public IViewComponentResult Invoke(hsDiv SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
