////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.html;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.html
{
    public class ButtonBase : ViewComponent
    {
        public IViewComponentResult Invoke(ButtonBaseManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
