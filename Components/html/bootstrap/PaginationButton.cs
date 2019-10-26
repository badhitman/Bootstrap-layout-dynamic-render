﻿////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov 
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponents
{
    public class PaginationButton : ViewComponent
    {
        public IViewComponentResult Invoke(PaginationButtonModel buttonSet)
        {
            return View(buttonSet.TypeButton.ToString(), buttonSet);
        }
    }
}