////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;

namespace BootstrapAspDynamicRender.models
{
    public class bmBrandNavItem : bsNavItem
    {
        /// <summary>
        /// Adding images 30x30 px to the .navbar-brand will likely always require custom styles or utilities to properly size.
        /// Here are some examples to demonstrate.
        /// </summary>
        public string ImageNavbarBrandSrc { get; set; }

        public bmBrandNavItem(string html_dom_id) : base(html_dom_id)
        {

        }
    }
}
