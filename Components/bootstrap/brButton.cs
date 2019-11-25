////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brButton : ViewComponent
    {
        public IViewComponentResult Invoke(hsButton SetObjectManager)
        {
            if (SetObjectManager is bsButtonLink)
                return View("Link", SetObjectManager);
            else if (SetObjectManager is bsButtonInput)
                return View("Input", SetObjectManager);
            else
                return View(SetObjectManager);
        }
    }
}
