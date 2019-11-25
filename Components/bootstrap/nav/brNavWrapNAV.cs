////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brNavWrapNAV : ViewComponent
    {
        public IViewComponentResult Invoke(absCoreNav SetObjectManager)
        {
            if (SetObjectManager is bsNavJavaScriptBehavior)
                return View("Wrap", SetObjectManager);
            else
                return View(SetObjectManager);

        }
    }
}
