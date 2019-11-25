////////////////////////////////////////////////
// https://github.com/badhitman 
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BootstrapAspDynamicRender.components
{
    public class brBreadcrumbs : ViewComponent
    {
        public IViewComponentResult Invoke(List<bmBreadcrumbItem> BreadcrumbItems)
        {
            return View(BreadcrumbItems);
        }
    }
}
