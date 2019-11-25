////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BootstrapAspDynamicRender.components
{
    public class hrUniversalList : ViewComponent
    {
        protected ILogger logger;
        public hrUniversalList(ILoggerFactory _loggerFactory)
        {
            logger = _loggerFactory.CreateLogger(GetType().Name + "Class");
        }

        public IViewComponentResult Invoke(ahsNestedTools SetObjectManager)
        {
            return View(SetObjectManager.GetChilds());
        }
    }
}
