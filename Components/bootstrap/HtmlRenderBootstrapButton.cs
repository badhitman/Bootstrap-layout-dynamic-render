using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap
{
    public class HtmlRenderBootstrapButton : ViewComponent
    {
        public IViewComponentResult Invoke(BootstrapButtonManager SetObjectManager)
        {
            if (SetObjectManager is BootstrapLinkButtonManager)
                return View("Link", SetObjectManager);
            else
                return View(SetObjectManager);
        }
    }
}
