////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrTableTr : ViewComponent
    {
        public IViewComponentResult Invoke(hsTableTr SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
