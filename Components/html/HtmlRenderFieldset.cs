using BootstrapViewComponentsRazorLibrary.Service.html;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html
{
    public class HtmlRenderFieldset : ViewComponent
    {
        public IViewComponentResult Invoke(FieldsetManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
