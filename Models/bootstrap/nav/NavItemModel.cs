////////////////////////////////////////////////
// © https://github.com/badhitman 
////////////////////////////////////////////////
using System.Collections.Generic;

namespace BootstrapViewComponentsRazorLibrary.Models.bootstrap
{
    /// <summary>
    /// Пункт меню nav-item
    /// </summary>
    public class NavItemModel
    {
        public string Header { get; set; }

        public string Href { get; set; }
        
        public bool IsActive { get; set; }

        public bool IsDisabled { get; set; }

        /// <summary>
        /// Вложеные под-пункты меню nav-item (максимальнео вложение 1)
        /// </summary>
        public List<NavItemModel> SubItems { get; set; }
    }
}
