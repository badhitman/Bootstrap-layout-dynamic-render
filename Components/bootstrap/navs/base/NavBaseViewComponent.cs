////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.nav
{
    public class NavBase : ViewComponent
    {
        protected ILogger logger;

        public NavBase(ILoggerFactory _loggerFactory)
        {
            logger = _loggerFactory.CreateLogger(this.GetType().Name + "Class");
        }

        /// <summary>
        /// Базовый Bootstrap Nav (компонент навигации)
        /// </summary>
        /// <param name="navManager"></param>
        /// <param name="SetPillsTheme"></param>
        /// <returns></returns>
        public IViewComponentResult Invoke(AbstractNavManager navManager, bool SetPillsTheme)
        {
            if (navManager.NavigationOrientation == Models.bootstrap.NavOrientationsEnum.HorizontallyFill && navManager.NavWrapperType == Models.NavWrapperTypesEnum.nav)
            {
                logger.LogInformation("When using a <nav>-based navigation, be sure to include .nav-item on the anchors.");
                navManager.Childs.ForEach(x => x.AddCSS("nav-item"));
            }

            if (navManager.IsTabsStyle && navManager.NavWrapperType != Models.NavWrapperTypesEnum.ul)
            {
                logger.LogError("Для Tabs допустим только UL формат обёртки. Автоматически установлен в NavWrapperTypesEnum.ul");
                navManager.NavWrapperType = Models.NavWrapperTypesEnum.ul;
            }

            if (navManager.IsTabsStyle && SetPillsTheme)
            {
                logger.LogError("Нельзя совмещать Pills и Tabs. Pils автоматически отключён");
                SetPillsTheme = false;
            }

            ViewBag.IsPillsTheme = SetPillsTheme;

            return View(navManager);
        }
    }
}
