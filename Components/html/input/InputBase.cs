////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.html;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.input
{
    public class InputBase : ViewComponent
    {
        public IViewComponentResult Invoke(InputManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
