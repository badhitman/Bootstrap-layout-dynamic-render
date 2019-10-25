////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.html
{
    public class ButtonBase : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
