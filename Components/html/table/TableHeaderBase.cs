using BootstrapViewComponentsRazorLibrary.Service.html.table;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html.table
{
    public class TableHeaderBase : ViewComponent
    {
        public IViewComponentResult Invoke(TableHeaderManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
