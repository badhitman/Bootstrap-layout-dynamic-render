////////////////////////////////////////////////
// © https://github.com/badhitman 
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.bootstrap.navs;
using BootstrapViewComponentsRazorLibrary.Service.bootstrap;
using System;

namespace BootstrapViewComponentsRazorLibrary.Models.bootstrap
{
    /// <summary>
    /// Пункт меню nav-item
    /// </summary>
    public class NavItemManager : AbstractCoreNavManager
    {
        public string Header { get; set; }

        public string Href { get; set; }

        public bool IsActive { get; set; }

        public bool IsDisabled { get; set; }

        public override string ViewComponentName => nameof(NavItemHtmlDomA);

        public NavItemManager(string html_dom_id)
        {
            if (string.IsNullOrWhiteSpace(html_dom_id))
                ID = Guid.NewGuid().ToString();
            else
                ID = html_dom_id;
        }

        public void AddSubNav(string header_nav, string href_nav = "#", string id_nav = null)
        {
            if (string.IsNullOrEmpty(header_nav))
            {
                Childs.Add(null);
                return;
            }

            Childs.Add(new NavItemManager(id_nav) { Header = header_nav, Href = href_nav });
        }
    }
}
