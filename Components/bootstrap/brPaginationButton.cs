////////////////////////////////////////////////
// https://github.com/badhitman 
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brPaginationButton : ViewComponent
    {
        public IViewComponentResult Invoke(bmPaginationButton buttonSet)
        {
            return View(buttonSet.TypeButton.ToString(), buttonSet);
        }
    }
}
