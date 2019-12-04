using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapAspDynamicRender.components
{
    public class hrBr : ViewComponent
    {
        public IViewComponentResult Invoke(hsBr SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
