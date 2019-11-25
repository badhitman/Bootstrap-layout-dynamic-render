////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrSpan : ViewComponent
    {
        public IViewComponentResult Invoke(hsSpan SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
