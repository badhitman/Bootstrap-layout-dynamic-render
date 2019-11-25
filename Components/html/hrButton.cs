////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrButton : ViewComponent
    {
        public IViewComponentResult Invoke(bsButton SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
