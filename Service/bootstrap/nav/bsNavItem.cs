////////////////////////////////////////////////
// © https://github.com/badhitman 
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;
using System;

namespace BootstrapAspDynamicRender.service
{
    /// <summary>
    /// Пункт меню nav-item
    /// </summary>
    public class bsNavItem : absCoreNav
    {
        public string Header { get; set; }

        public string Href { get; set; }

        public bool IsActive { get; set; }

        public bool IsDisabled { get; set; }

        public override string ViewComponentName => nameof(brNavItemA);

        public bsNavItem(string html_dom_id)
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
                ChildsNodes.Add(null);
                return;
            }

            ChildsNodes.Add(new bsNavItem(id_nav) { Header = header_nav, Href = href_nav });
        }
    }
}
