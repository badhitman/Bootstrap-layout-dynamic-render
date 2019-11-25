////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrLabel : ViewComponent
    {
        public IViewComponentResult Invoke(hsLabelInput SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
