////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navbar
{
    public class NavbarBase : ViewComponent
    {
        protected ILogger logger;

        public NavbarBase(ILoggerFactory _loggerFactory)
        {
            logger = _loggerFactory.CreateLogger(GetType().Name + "Class");
        }

        public IViewComponentResult Invoke(NavbarManager SetObjectManager)
        {
            if (SetObjectManager.NavbarExpandSize == BootstrapViewComponents.BootstrapSizingEnum.Block)
            {
                SetObjectManager.NavbarExpandSize = BootstrapViewComponents.BootstrapSizingEnum.Lg;
                logger.LogError("Для Navbar размер Block не предусмотрен. Будет сброшено на Lg");
            }

            SetObjectManager.AddCSS("navbar");
            switch (SetObjectManager.NavbarPlacement)
            {
                case Models.bootstrap.NavbarPlacementsEnum.FixedTop:
                    SetObjectManager.AddCSS("fixed-top");
                    break;
                case Models.bootstrap.NavbarPlacementsEnum.FixedBottom:
                    SetObjectManager.AddCSS("fixed-bottom");
                    break;
                case Models.bootstrap.NavbarPlacementsEnum.StickyTop:
                    SetObjectManager.AddCSS("sticky-top");
                    break;
                default:

                    break;
            }

            if (SetObjectManager.NavbarExpandSize != BootstrapViewComponents.BootstrapSizingEnum.NULL)
            {
                SetObjectManager.AddCSS("navbar-expand-" + SetObjectManager.NavbarExpandSize.ToString().ToLower());
            }
            if (SetObjectManager.BackgroundColorTheme != Models.bootstrap.BackgroundColorThemesEnum.NULL)
            {
                SetObjectManager.AddCSS("bg-" + SetObjectManager.BackgroundColorTheme.ToString().ToLower());
            }
            if (SetObjectManager.NavbarColorScheme != MonochromeColorSchemesEnum.NULL)
            {
                SetObjectManager.AddCSS("navbar-" + SetObjectManager.NavbarColorScheme.ToString().ToLower());
            }

            return View(SetObjectManager);
        }
    }
}
