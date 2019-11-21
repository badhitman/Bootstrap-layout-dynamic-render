using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap
{
    public class BootstrapRenderModal : ViewComponent
    {
        public IViewComponentResult Invoke(ModalManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
