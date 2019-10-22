////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navbar
{
    public class NavbarBrand : ViewComponent
    {
        protected ILogger logger;

        public NavbarBrand(ILoggerFactory _loggerFactory)
        {
            logger = _loggerFactory.CreateLogger(this.GetType().Name + "Class");
        }

        public IViewComponentResult Invoke(string SetBrandHeader, string SetBrandHref, string SetBrandImgSrc)
        {
            ViewBag.BrandHeader = SetBrandHeader;
            ViewBag.BrandHref = SetBrandHref;
            ViewBag.BrandImgSrc = SetBrandImgSrc;
            return View();
        }
    }
}
