using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BootstrapViewComponents
{
    public class Breadcrumbs : ViewComponent
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
