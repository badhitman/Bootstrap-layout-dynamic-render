////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.nav
{
    public class NavBaseViewComponent : ViewComponent
    {
        protected ILogger logger;

        public NavBaseViewComponent(ILoggerFactory _loggerFactory)
        {
            logger = _loggerFactory.CreateLogger(this.GetType().Name + "Class");
        }

        /// <summary>
        /// Базовый Bootstrap Nav (компонент навигации)
        /// </summary>
        /// <param name="navManager"></param>
        /// <param name="SetPillsTheme"></param>
        /// <returns></returns>
        public IViewComponentResult Invoke(AbstractNavManager navManager, bool SetPillsTheme = false)
        {
            if (navManager.IsTabsStyle && SetPillsTheme)
            {
                logger.LogError("Нельзя совмещать Pills и Tabs. Pils будет отключён");
                SetPillsTheme = false;
            }

            ViewBag.IsPillsTheme = SetPillsTheme;

            return View(navManager);
        }
    }
}
