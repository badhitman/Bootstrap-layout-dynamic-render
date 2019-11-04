////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BootstrapViewComponentsRazorLibrary.Components.html
{
    public class UniversalList : ViewComponent
    {
        protected ILogger logger;
        public UniversalList(ILoggerFactory _loggerFactory)
        {
            logger = _loggerFactory.CreateLogger(this.GetType().Name + "Class");
        }

        public IViewComponentResult Invoke(AbstractNestedToolsManager SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
