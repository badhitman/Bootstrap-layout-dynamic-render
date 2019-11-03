using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap
{
    public class InputGroupBase : ViewComponent
    {
        public IViewComponentResult Invoke(InputGroupManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
