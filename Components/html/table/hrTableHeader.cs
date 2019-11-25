////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrTableHeader : ViewComponent
    {
        public IViewComponentResult Invoke(hsTableHeader SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
