using BootstrapViewComponentsRazorLibrary.Service.html.table;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html.table
{
    public class TableTdBase : ViewComponent
    {
        public IViewComponentResult Invoke(TableTdManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
