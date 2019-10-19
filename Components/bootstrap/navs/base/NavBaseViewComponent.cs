﻿////////////////////////////////////////////////
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
        public IViewComponentResult Invoke(AbstractNavManager navManager, bool SetPillsTheme = false)
        {
            if ((navManager.NavigationOrientation == Models.bootstrap.NavOrientationsEnum.HorizontallyFill ||
                navManager.NavigationOrientation == Models.bootstrap.NavOrientationsEnum.HorizontallyJustified ||
                navManager.IsTabsStyle) &&
                navManager.NavWrapperType == Models.NavWrapperTypesEnum.nav)
            {
                logger.LogInformation("When using a <nav>-based navigation, be sure to include .nav-item on the anchors.");
                navManager.Childs.ForEach(x => x.AddCSS("nav-item"));
            }

            if (navManager.IsTabsStyle && SetPillsTheme)
                logger.LogError("Нет смысла совмещать Pills и Tabs. Устраните ошибку");

            if (navManager.NavigationOrientation == Models.bootstrap.NavOrientationsEnum.HorizontallyFlexUtilities)
            {
                logger.LogInformation("Working with flex utilities. If you need responsive nav variations, consider using a series of flexbox utilities.While more verbose, these utilities offer greater customization across responsive breakpoints. In the example below, our nav will be stacked on the lowest breakpoint, then adapt to a horizontal layout that fills the available width starting from the small breakpoint.");
                navManager.Childs.ForEach(x => x.AddCSS("flex-sm-fill text-sm-center", true));
            }

            ViewBag.IsPillsTheme = SetPillsTheme;

            return View(navManager);
        }
    }
}
