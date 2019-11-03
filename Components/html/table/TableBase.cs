////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.html;
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
            return View(SetObjectManager);
        }
    }
}
