////////////////////////////////////////////////
// https://github.com/badhitman 
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BootstrapViewComponents
{
    public class Breadcrumbs : ViewComponent
    {
        public IViewComponentResult Invoke(List<BreadcrumbItemModel> BreadcrumbItems)
        {
            return View(BreadcrumbItems);
        }
    }
}
