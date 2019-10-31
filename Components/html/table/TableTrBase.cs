﻿using BootstrapViewComponentsRazorLibrary.Service.html.table;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html.table
{
    public class TableTrBase : ViewComponent
    {
        public IViewComponentResult Invoke(TableTrManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}