////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov 
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap
{
    public class FormBase : ViewComponent
    {
        protected ILogger logger;

        public FormBase(ILoggerFactory _loggerFactory)
        {
            logger = _loggerFactory.CreateLogger(this.GetType().Name + "Class");
        }

        public IViewComponentResult Invoke(FormManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
