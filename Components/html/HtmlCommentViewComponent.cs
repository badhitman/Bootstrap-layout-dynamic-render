﻿////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.html
{
    public class HtmlCommentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string MessageComment)
        {
            return View(MessageComment);
        }
    }
}
