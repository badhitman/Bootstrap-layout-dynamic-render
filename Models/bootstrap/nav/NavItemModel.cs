////////////////////////////////////////////////
// © https://github.com/badhitman 
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service;
using System;
using System.Linq;

namespace BootstrapViewComponentsRazorLibrary.Models.bootstrap
{
    /// <summary>
    /// Пункт меню nav-item
    /// </summary>
    public class NavItemModel : AbstractSafeNestedToolsManager
    {
        public string Header { get; set; }

        public string Href { get; set; }

        public bool IsActive { get; set; }

        public bool IsDisabled { get; set; }

        public NavItemModel(string html_dom_id)
        {
            if (string.IsNullOrWhiteSpace(html_dom_id))
                Id_DOM = Guid.NewGuid().ToString();
            else
                Id_DOM = html_dom_id;
        }

        /// <summary>
        /// Сброс состояния (IsActive||IsDisable)
        /// </summary>
        public void ResetNavItems()
        {
            IsActive = false;
            IsDisabled = false;
            foreach (NavItemModel nav_sub_item in GetChilds().Where(x => !(x is null)))
                nav_sub_item.ResetNavItems();
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
