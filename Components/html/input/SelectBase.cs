////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html.input
{
    public class SelectBase : ViewComponent
    {
        public IViewComponentResult Invoke(AbstractInputManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
