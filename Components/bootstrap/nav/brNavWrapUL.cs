////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brNavWrapUL : ViewComponent
    {
        public IViewComponentResult Invoke(absCoreNav SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
