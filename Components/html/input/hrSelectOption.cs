////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrSelectOption : ViewComponent
    {
        public IViewComponentResult Invoke(hsInputOptionSelect SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
