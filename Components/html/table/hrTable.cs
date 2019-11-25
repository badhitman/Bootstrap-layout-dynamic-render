////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrTable : ViewComponent
    {
        public IViewComponentResult Invoke(hsTable SetObjectManager)
        {
            if(SetObjectManager is bsTable)
                return View("Bootstrap", SetObjectManager);

            return View(SetObjectManager);
        }
    }
}
