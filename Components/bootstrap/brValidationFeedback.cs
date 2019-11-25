////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using Microsoft.AspNetCore.Mvc;

namespace BootstrapAspDynamicRender.components
{
    public class brValidationFeedback : ViewComponent
    {
        public IViewComponentResult Invoke(string SetMessageValidFeedback = null, string SetMessageInvalidFeedback = null)
        {
            ViewBag.ValidFeedback = SetMessageValidFeedback;
            ViewBag.InvalidFeedback = SetMessageInvalidFeedback;

            return View();
        }
    }
}
