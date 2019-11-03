using BootstrapViewComponentsRazorLibrary.Service.html;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html.input
{
    public class LabelBase : ViewComponent
    {
        public IViewComponentResult Invoke(LabelManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
