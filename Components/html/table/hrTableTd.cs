////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrTableTd : ViewComponent
    {
        public IViewComponentResult Invoke(hsTableTd SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
