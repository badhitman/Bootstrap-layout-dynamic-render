////////////////////////////////////////////////
// © https://github.com/badhitman 
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Service;
using System;
using System.Collections.Generic;

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

        /// <summary>
        /// Вложеные под-пункты меню nav-item (максимальнео вложение 1)
        /// </summary>
        public List<NavItemModel> SubItems { get; set; }

        public NavItemModel(string html_dom_id)
        {
            if (string.IsNullOrWhiteSpace(html_dom_id))
                Id_DOM = Guid.NewGuid().ToString();
            else
                Id_DOM = html_dom_id;
        }
    }
}
