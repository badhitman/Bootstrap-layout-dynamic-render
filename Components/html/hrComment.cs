////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class hrComment : ViewComponent
    {
        public IViewComponentResult Invoke(string MessageComment)
        {
            return View(MessageComment);
        }
    }
}
