////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrP : ViewComponent
    {
        public IViewComponentResult Invoke(hsP SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
