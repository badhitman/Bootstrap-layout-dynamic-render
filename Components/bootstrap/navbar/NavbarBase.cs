////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
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

        public IViewComponentResult Invoke(NavbarManager navbarManager)
        {
            if(navbarManager.NavbarExpandSize == BootstrapViewComponents.BootstrapSizingEnum.Block)
            {
                navbarManager.NavbarExpandSize = BootstrapViewComponents.BootstrapSizingEnum.Lg;
                logger.LogError("Для Navbar размер Block не предусмотрен. Будет сброшено на Lg");
            }

            navbarManager.AddCSS("navbar");
            switch (navbarManager.NavbarPlacement)
            {
                case Models.bootstrap.NavbarPlacementsEnum.FixedTop:
                    navbarManager.AddCSS("fixed-top");
                    break;
                case Models.bootstrap.NavbarPlacementsEnum.FixedBottom:
                    navbarManager.AddCSS("fixed-bottom");
                    break;
                case Models.bootstrap.NavbarPlacementsEnum.StickyTop:
                    navbarManager.AddCSS("sticky-top");
                    break;
                default:

                    break;
            }

            if (navbarManager.NavbarExpandSize != BootstrapViewComponents.BootstrapSizingEnum.NULL)
            {
                navbarManager.AddCSS("navbar-expand-" + navbarManager.NavbarExpandSize.ToString().ToLower());
            }
            if (navbarManager.BackgroundColorTheme != Models.bootstrap.BackgroundColorThemesEnum.NULL)
            {
                navbarManager.AddCSS("bg-" + navbarManager.BackgroundColorTheme.ToString().ToLower());
            }
            if (navbarManager.NavbarColorScheme != Models.bootstrap.NavbarColorSchemesEnum.NULL)
            {
                navbarManager.AddCSS("navbar-" + navbarManager.NavbarColorScheme.ToString().ToLower());
            }

            return View(navbarManager);
        }
    }
}
