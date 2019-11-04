using BootstrapViewComponentsRazorLibrary.Service.html;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html
{
    public class HtmlRenderSpan : ViewComponent
    {
        public IViewComponentResult Invoke(SpanManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
