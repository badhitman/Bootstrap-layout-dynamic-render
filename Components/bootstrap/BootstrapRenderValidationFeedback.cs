using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap
{
    public class BootstrapRenderValidationFeedback : ViewComponent
    {
        public IViewComponentResult Invoke(string SetMessageValidFeedback = null, string SetMessageInvalidFeedback = null)
        {
            ViewBag.ValidFeedback = SetMessageValidFeedback;
            ViewBag.InvalidFeedback = SetMessageInvalidFeedback;

            return View();
        }
    }
}
