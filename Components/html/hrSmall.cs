////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrSmall : ViewComponent
    {
        public IViewComponentResult Invoke(hsSmall SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
