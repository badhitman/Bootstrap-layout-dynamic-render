////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrTableTh : ViewComponent
    {
        public IViewComponentResult Invoke(hsTableTh SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
