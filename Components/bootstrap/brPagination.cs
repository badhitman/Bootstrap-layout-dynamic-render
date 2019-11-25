////////////////////////////////////////////////
// https://github.com/badhitman 
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brPagination : ViewComponent
    {
        public IViewComponentResult Invoke(bsPagination pagination)
        {
            return View(pagination);
        }
    }
}
