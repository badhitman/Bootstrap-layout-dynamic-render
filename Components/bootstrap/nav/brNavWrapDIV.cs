////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brNavWrapDIV : ViewComponent
    {
        public IViewComponentResult Invoke(absCoreNav SetObjectManager)
        {
            SetObjectManager.ChildsAddCSS("nav-item");
            return View(SetObjectManager);
        }
    }
}
