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
    public class NavItemModel : AbstractCoreNavManager
    {
        public string Header { get; set; }

        public string Href { get; set; }

        public bool IsActive { get; set; }

        public bool IsDisabled { get; set; }

        public override string ViewComponentName => nameof(NavItemHtmlDomA);

        public NavItemModel(string html_dom_id)
        {
            if (string.IsNullOrWhiteSpace(html_dom_id))
                Id_DOM = Guid.NewGuid().ToString();
            else
                Id_DOM = html_dom_id;
        }

        public void AddSubNav(string header_nav, string href_nav = "#", string id_dom = null)
        {
            if (string.IsNullOrEmpty(header_nav))
            {
                Childs.Add(null);
                return;
            }

            Childs.Add(new NavItemModel(id_dom) { Header = header_nav, Href = href_nav });
        }
    }
}
