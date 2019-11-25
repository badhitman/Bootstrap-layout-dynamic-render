////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brModal : ViewComponent
    {
        public IViewComponentResult Invoke(bsModal SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
