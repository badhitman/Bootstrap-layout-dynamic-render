////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.html;
using BootstrapViewComponentsRazorLibrary.Service.html.bootstrap;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html
{
    public class TableBase : ViewComponent
    {
        public IViewComponentResult Invoke(TableManager SetObjectManager)
        {
            if(SetObjectManager is TableBootstrapManager)
                return View("Bootstrap", SetObjectManager);

            return View(SetObjectManager);
        }
    }
}
