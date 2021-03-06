﻿////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BootstrapAspDynamicRender.components
{
    public class brNavbarBrand : ViewComponent
    {
        protected ILogger logger;

        public brNavbarBrand(ILoggerFactory _loggerFactory)
        {
            logger = _loggerFactory.CreateLogger(this.GetType().Name + "Class");
        }

        public IViewComponentResult Invoke(bsNavbarBrand SetObjectManager)
        {
            if (SetObjectManager?.NavbarBrandDom is null)
                return View("Empty");

            string BrandHeader = SetObjectManager.NavbarBrandDom.Header;
            string BrandHref = SetObjectManager.NavbarBrandDom.Href;
            string BrandImgSrc = SetObjectManager.NavbarBrandDom.ImageNavbarBrandSrc;

            if (string.IsNullOrWhiteSpace(BrandHeader) && BrandHeader == BrandHref && BrandHref == BrandImgSrc)
                return View("Empty");

            SetObjectManager.AddCSS("navbar-brand");

            if (string.IsNullOrWhiteSpace(BrandHref) && string.IsNullOrWhiteSpace(BrandImgSrc))
            {
                SetObjectManager.AddCSS("mb-0 h1");
                return View("Span", SetObjectManager);
            }

            if (string.IsNullOrWhiteSpace(BrandHref))
                SetObjectManager.NavbarBrandDom.Href = "#";

            SetObjectManager.SetAttribute("href", SetObjectManager.NavbarBrandDom.Href);

            return View(SetObjectManager);
        }
    }
}
