﻿////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brNavItemA : ViewComponent
    {
        public IViewComponentResult Invoke(bsNavItem SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
