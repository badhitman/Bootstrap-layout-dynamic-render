using BootstrapViewComponentsRazorLibrary.Service.html.input;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html.input
{
   public class OptionSelectBase : ViewComponent
    {
        public IViewComponentResult Invoke(OptionSelectManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
