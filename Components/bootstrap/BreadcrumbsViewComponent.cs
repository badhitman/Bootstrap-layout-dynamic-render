////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov 
////////////////////////////////////////////////
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BootstrapViewComponents
{
    public class BreadcrumbsViewComponent : ViewComponent
    {
        public class BreadcrumbItem
        {
            public string text;
            public string href;
        }

        public IViewComponentResult Invoke(List<BreadcrumbItem> BreadcrumbItems)
        {
            return View(BreadcrumbItems);
        }
    }
}
