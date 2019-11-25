////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brInputGroup : ViewComponent
    {
        public IViewComponentResult Invoke(bsInputGroup SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
