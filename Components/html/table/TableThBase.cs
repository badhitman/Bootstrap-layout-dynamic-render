////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.html.table;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html.table
{
    public class TableThBase : ViewComponent
    {
        public IViewComponentResult Invoke(TableThManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
