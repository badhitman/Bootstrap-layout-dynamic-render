using BootstrapViewComponentsRazorLibrary.Service.html;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html
{
    public class HtmlRenderLink : ViewComponent
    {
        public IViewComponentResult Invoke(LinkBasicManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
