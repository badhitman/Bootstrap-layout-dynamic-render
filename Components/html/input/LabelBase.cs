////////////////////////////////////////////////
// MIT License. https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.html;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html.input
{
    public class LabelBase : ViewComponent
    {
        public IViewComponentResult Invoke(LabelInputManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
