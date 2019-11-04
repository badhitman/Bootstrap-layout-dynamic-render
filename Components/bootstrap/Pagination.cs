////////////////////////////////////////////////
// https://github.com/badhitman 
////////////////////////////////////////////////
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponents
{
    public class Pagination : ViewComponent
    {
        public IViewComponentResult Invoke(PaginationManager pagination)
        {
            return View(pagination);
        }
    }
}
