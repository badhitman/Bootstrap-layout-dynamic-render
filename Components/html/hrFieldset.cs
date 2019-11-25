////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrFieldset : ViewComponent
    {
        public IViewComponentResult Invoke(hsFieldset SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
