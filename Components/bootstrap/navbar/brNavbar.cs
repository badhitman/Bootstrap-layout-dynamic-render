////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BootstrapAspDynamicRender.components
{
    public class brNavbar : ViewComponent
    {
        protected ILogger logger;

        public brNavbar(ILoggerFactory _loggerFactory)
        {
            logger = _loggerFactory.CreateLogger(GetType().Name + "Class");
        }

        public IViewComponentResult Invoke(bsNavbar SetObjectManager)
        {
            if (SetObjectManager.NavbarExpandSize == bmSizingsEnum.Block)
            {
                SetObjectManager.NavbarExpandSize = bmSizingsEnum.Lg;
                logger.LogError("Для Navbar размер Block не предусмотрен. Будет сброшено на Lg");
            }

            SetObjectManager.AddCSS("navbar");
            switch (SetObjectManager.NavbarPlacement)
            {
                case bmNavbarPlacementsEnum.FixedTop:
                    SetObjectManager.AddCSS("fixed-top");
                    break;
                case bmNavbarPlacementsEnum.FixedBottom:
                    SetObjectManager.AddCSS("fixed-bottom");
                    break;
                case bmNavbarPlacementsEnum.StickyTop:
                    SetObjectManager.AddCSS("sticky-top");
                    break;
                default:

                    break;
            }

            if (SetObjectManager.NavbarExpandSize != bmSizingsEnum.NULL)
            {
                SetObjectManager.AddCSS("navbar-expand-" + SetObjectManager.NavbarExpandSize.ToString().ToLower());
            }
            if (SetObjectManager.BackgroundColorTheme != bmBackgroundColorThemesEnum.NULL)
            {
                SetObjectManager.AddCSS("bg-" + SetObjectManager.BackgroundColorTheme.ToString().ToLower());
            }
            if (SetObjectManager.NavbarColorScheme != bmMonochromeColorSchemesEnum.NULL)
            {
                SetObjectManager.AddCSS("navbar-" + SetObjectManager.NavbarColorScheme.ToString().ToLower());
            }

            return View(SetObjectManager);
        }
    }
}
