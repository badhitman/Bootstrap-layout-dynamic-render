////////////////////////////////////////////////
// MIT License. https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap.input;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap
{
    public class CustomInputBase : ViewComponent
    {
        public IViewComponentResult Invoke(AbstractCustomInputManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
