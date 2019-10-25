////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

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
        /// <param name="SetObjectManager"></param>
        /// <param name="SetPillsTheme"></param>
        /// <returns></returns>
        public IViewComponentResult Invoke(AbstractNavManager SetObjectManager, bool SetPillsTheme = false)
        {
            if (SetObjectManager.IsTabsStyle && SetObjectManager.NavWrapperType == Models.NavWrapperTypesEnum.nav)
            {
                logger.LogInformation("When using a <nav>-based navigation, be sure to include .nav-item on the anchors.");
                SetObjectManager.Childs.ForEach(x => x.AddCSS("nav-item"));
            }

            if (SetObjectManager.IsTabsStyle && SetPillsTheme)
            {
                logger.LogError(" Нельзя совмещать Pills и Tabs. По умолчанию Pills в таких случаях отключается");
                SetPillsTheme = false;
            }

            if (SetObjectManager.IsTabsStyle && SetObjectManager.NavigationOrientation == NavOrientationsEnum.Vertically)
            {
                string msg = "Для Tabs не предусмотрено вертикальное позиционирование.";
                logger.LogError(msg + " Устраните ошибку");
                throw new ArgumentException(msg, nameof(SetObjectManager.NavigationOrientation));
            }

             if (SetPillsTheme)
                SetObjectManager.AddCSS("nav-pills");
            else if(SetObjectManager.IsTabsStyle)
                SetObjectManager.AddCSS("nav-tabs");
            
            if (SetObjectManager is NavJavaScriptBehaviorManager)
                SetObjectManager.SetAttribute("role", "tablist");

            switch (SetObjectManager.NavigationOrientation)
            {
                case NavOrientationsEnum.HorizontallyCenterAligned:
                    SetObjectManager.AddCSS("justify-content-center");
                    break;
                case NavOrientationsEnum.HorizontallyRightAligned:
                    SetObjectManager.AddCSS("justify-content-end");
                    break;
                case NavOrientationsEnum.Vertically:
                    if (!SetObjectManager.ReadCSS().Any(x => x.StartsWith("flex-") && x.EndsWith("-column")))
                        SetObjectManager.AddCSS("flex-column");

                    SetObjectManager.IsTabsStyle = false;
                    break;
                case NavOrientationsEnum.HorizontallyFill:
                    SetObjectManager.AddCSS("nav-fill");
                    break;
                case NavOrientationsEnum.HorizontallyJustified:
                    SetObjectManager.AddCSS("nav-justified");
                    break;
                default:

                    break;
            }

            if (SetObjectManager is NavJavaScriptBehaviorManager && SetObjectManager.NavigationOrientation == NavOrientationsEnum.Vertically)
                return View("VerticallyNavJavaScriptBehavior", SetObjectManager);
            else
                return View(SetObjectManager);
        }
    }
}
