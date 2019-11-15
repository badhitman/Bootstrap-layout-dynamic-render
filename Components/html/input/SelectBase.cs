////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html;
using BootstrapViewComponentsRazorLibrary.Service.html.input;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html.input
{
    public class SelectBase : ViewComponent
    {
        public IViewComponentResult Invoke(InputSelectManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
