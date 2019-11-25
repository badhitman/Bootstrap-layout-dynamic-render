////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrSelect : ViewComponent
    {
        public IViewComponentResult Invoke(hsInputSelect SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
