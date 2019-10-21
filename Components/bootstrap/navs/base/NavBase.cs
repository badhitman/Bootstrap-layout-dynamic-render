////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

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
            {
                string msg = "Нельзя совмещать Pills и Tabs.";
                logger.LogError(msg + " Устраните ошибку");
                throw new ArgumentException(msg, nameof(SetPillsTheme));
            }

            if (navManager.IsTabsStyle && navManager.NavigationOrientation == Models.bootstrap.NavOrientationsEnum.Vertically)
            {
                string msg = "Для Tabs не предусмотрено вертикальное позиционирование.";
                logger.LogError(msg + " Устраните ошибку");
                throw new ArgumentException(msg, nameof(navManager.NavigationOrientation));
            }

            ViewBag.IsPillsTheme = SetPillsTheme;

            if(navManager is NavJavaScriptBehaviorManager && navManager.NavigationOrientation == Models.bootstrap.NavOrientationsEnum.Vertically)
                return View("VerticallyNavJavaScriptBehavior", navManager);

            return View(navManager);
        }
    }
}
