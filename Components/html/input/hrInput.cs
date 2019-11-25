////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrInput : ViewComponent
    {
        public IViewComponentResult Invoke(ahsInputs SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
