using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrRaw : ViewComponent
    {
        public IViewComponentResult Invoke(hsRaw SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
