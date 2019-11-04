////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html
{
    public class DivBase : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
