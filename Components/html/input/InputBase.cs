////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.html;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.input
{
    public class InputBase : ViewComponent
    {
        public IViewComponentResult Invoke(AbstractInputManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
