////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace BootstrapAspDynamicRender.components
{
    public class brNavBase : ViewComponent
    {
        protected ILogger logger;

        public brNavBase(ILoggerFactory _loggerFactory)
        {
            logger = _loggerFactory.CreateLogger(GetType().Name + "Class");
        }

        /// <summary>
        /// Базовый Bootstrap Nav (компонент навигации)
        /// </summary>
        /// <param name="SetObjectManager"></param>
        /// <param name="SetPillsTheme"></param>
        /// <returns></returns>
        public IViewComponentResult Invoke(absNav SetObjectManager, bool SetPillsTheme = false)
        {
            if ((SetObjectManager.NavigationOrientation == bmNavOrientationsEnum.HorizontallyFill ||
                SetObjectManager.NavigationOrientation == bmNavOrientationsEnum.HorizontallyJustified ||
                SetObjectManager.IsTabsStyle) && 
                SetObjectManager.NavWrapperType == bmNavWrappersEnum.nav)
            {
                logger.LogInformation("When using a <nav>-based navigation, be sure to include .nav-item on the anchors.");
                SetObjectManager.ChildsNodes.ForEach(x => x.AddCSS("nav-item"));
            }

            if (SetObjectManager.IsTabsStyle && SetPillsTheme)
            {
                logger.LogError(" Нельзя совмещать Pills и Tabs. По умолчанию Pills в таких случаях отключается");
                SetPillsTheme = false;
            }

            if (SetObjectManager.IsTabsStyle && SetObjectManager.NavigationOrientation == bmNavOrientationsEnum.Vertically)
            {
                string msg = "Для Tabs не предусмотрено вертикальное позиционирование.";
                logger.LogError(msg + " Устраните ошибку");
                throw new ArgumentException(msg, nameof(SetObjectManager.NavigationOrientation));
            }

             if (SetPillsTheme)
                SetObjectManager.AddCSS("nav-pills");
            else if(SetObjectManager.IsTabsStyle)
                SetObjectManager.AddCSS("nav-tabs");
            
            if (SetObjectManager is bsNavJavaScriptBehavior)
                SetObjectManager.SetAttribute("role", "tablist");

            switch (SetObjectManager.NavigationOrientation)
            {
                case bmNavOrientationsEnum.HorizontallyCenterAligned:
                    SetObjectManager.AddCSS("justify-content-center");
                    break;
                case bmNavOrientationsEnum.HorizontallyRightAligned:
                    SetObjectManager.AddCSS("justify-content-end");
                    break;
                case bmNavOrientationsEnum.Vertically:
                    if (!SetObjectManager.ReadCSS().Any(x => x.StartsWith("flex-") && x.EndsWith("-column")))
                        SetObjectManager.AddCSS("flex-column");

                    SetObjectManager.IsTabsStyle = false;
                    break;
                case bmNavOrientationsEnum.HorizontallyFill:
                    SetObjectManager.AddCSS("nav-fill");
                    break;
                case bmNavOrientationsEnum.HorizontallyJustified:
                    SetObjectManager.AddCSS("nav-justified");
                    break;
                default:

                    break;
            }

            if (SetObjectManager is bsNavJavaScriptBehavior && SetObjectManager.NavigationOrientation == bmNavOrientationsEnum.Vertically)
                return View("VerticallyNavJavaScriptBehavior", SetObjectManager);
            else
                return View(SetObjectManager);
        }
    }
}
