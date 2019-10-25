////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.input
{
    public class InputBase : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
