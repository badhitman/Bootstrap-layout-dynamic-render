////////////////////////////////////////////////
// https://github.com/badhitman 
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BootstrapAspDynamicRender.components
{
    public class brForm : ViewComponent
    {
        protected ILogger logger;

        public brForm(ILoggerFactory _loggerFactory)
        {
            logger = _loggerFactory.CreateLogger(this.GetType().Name + "Class");
        }

        public IViewComponentResult Invoke(hsForm SetObjectManager)
        {
            return View(SetObjectManager);
        }
    }
}
