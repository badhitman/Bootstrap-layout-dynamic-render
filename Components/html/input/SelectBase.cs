using BootstrapViewComponentsRazorLibrary.Service.html;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html.input
{
    public class SelectBase : ViewComponent
    {
        public IViewComponentResult Invoke(AbstractInputsManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
