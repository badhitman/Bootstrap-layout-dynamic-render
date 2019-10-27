////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapViewComponentsRazorLibrary.Components.bootstrap.navs
{
    public class NavItemHtmlDomA : ViewComponent
    {
        public IViewComponentResult Invoke(NavItemModel SetObjectManager)
        {
            SetObjectManager.AddCSS("nav-link");
            if (SetObjectManager.IsActive)
            {
                SetObjectManager.AddCSS("active");
                string sr_html_injection = "<span class=\"sr-only\">(current)</span>";
                if (!SetObjectManager.Header.EndsWith(sr_html_injection))
                    SetObjectManager.Header += " " + sr_html_injection;
            }
            if (SetObjectManager.ChildsCount > 0)
            {
                SetObjectManager.AddCSS("dropdown-toggle");
                SetObjectManager.SetAttribute("data-toggle", "dropdown");
                SetObjectManager.SetAttribute("role", "button");
                SetObjectManager.SetAttribute("aria-haspopup", "true");
                SetObjectManager.SetAttribute("aria-expanded", "false");
            }
            if (SetObjectManager.IsDisabled)
            {
                SetObjectManager.AddCSS(" disabled");
                SetObjectManager.Tabindex = -1;
                SetObjectManager.SetAttribute("aria-disabled", "true");
            }
            return View(SetObjectManager);
        }
    }
}
