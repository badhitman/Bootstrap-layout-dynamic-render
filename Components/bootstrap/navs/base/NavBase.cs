////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.nav
{
    public class NavBase : ViewComponent
    {
        protected ILogger logger;

        public NavBase(ILoggerFactory _loggerFactory)
        {
            logger = _loggerFactory.CreateLogger(GetType().Name + "Class");
        }

        /// <summary>
        /// Базовый Bootstrap Nav (компонент навигации)
        /// </summary>
        /// <param name="navManager"></param>
        /// <param name="SetPillsTheme"></param>
        /// <returns></returns>
        public IViewComponentResult Invoke(AbstractNavManager navManager, bool SetPillsTheme = false)
        {
            if ((navManager.NavigationOrientation == NavOrientationsEnum.HorizontallyFill ||
                navManager.NavigationOrientation == NavOrientationsEnum.HorizontallyJustified ||
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

            if (navManager.IsTabsStyle && navManager.NavigationOrientation == NavOrientationsEnum.Vertically)
            {
                string msg = "Для Tabs не предусмотрено вертикальное позиционирование.";
                logger.LogError(msg + " Устраните ошибку");
                throw new ArgumentException(msg, nameof(navManager.NavigationOrientation));
            }

            ViewBag.IsPillsTheme = SetPillsTheme;

            switch (navManager.NavigationOrientation)
            {
                case NavOrientationsEnum.HorizontallyCenterAligned:
                    navManager.AddCSS("justify-content-center");
                    break;
                case NavOrientationsEnum.HorizontallyRightAligned:
                    navManager.AddCSS("justify-content-end");
                    break;
                case NavOrientationsEnum.Vertically:
                    if (!navManager.ReadCSS().Any(x => x.StartsWith("flex-") && x.EndsWith("-column")))
                        navManager.AddCSS("flex-column");

                    navManager.IsTabsStyle = false;
                    break;
                case NavOrientationsEnum.HorizontallyFill:
                    navManager.AddCSS("nav-fill");
                    break;
                case NavOrientationsEnum.HorizontallyJustified:
                    navManager.AddCSS("nav-justified");
                    break;
                default:

                    break;
            }

            if (navManager is NavJavaScriptBehaviorManager && navManager.NavigationOrientation == NavOrientationsEnum.Vertically)
                return View("VerticallyNavJavaScriptBehavior", navManager);
            else
                return View(navManager);
        }
    }
}
