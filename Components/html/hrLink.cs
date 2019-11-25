////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrLink : ViewComponent
    {
        public IViewComponentResult Invoke(hsLinkBasic SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
