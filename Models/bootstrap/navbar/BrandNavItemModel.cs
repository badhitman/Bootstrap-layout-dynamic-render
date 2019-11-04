////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;

namespace BootstrapViewComponentsRazorLibrary.Models.html.bootstrap.navbar
{
    public class BrandNavItemModel : NavItemManager
    {
        /// <summary>
        /// Adding images 30x30 px to the .navbar-brand will likely always require custom styles or utilities to properly size.
        /// Here are some examples to demonstrate.
        /// </summary>
        public string ImageNavbarBrandSrc { get; set; }

        public BrandNavItemModel(string html_dom_id) : base(html_dom_id)
        {

        }
    }
}
