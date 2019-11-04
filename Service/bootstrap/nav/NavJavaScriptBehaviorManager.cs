////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.bootstrap.nav;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using System;
using System.Collections.Generic;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    /// <summary>
    /// JavaScript behavior
    /// 
    /// Use the tab JavaScript plugin—include it individually or through the compiled bootstrap.js file—to extend our navigational tabs and pills to create tabbable panes of local content, even via dropdown menus.
    /// If you’re building our JavaScript from source, it requires util.js.
    /// Dynamic tabbed interfaces, as described in the WAI ARIA Authoring Practices, require role="tablist", role="tab", role="tabpanel", and additional aria- attributes in order to convey their structure, functionality and current state to users of assistive technologies (such as screen readers).
    /// 
    /// Note that dynamic tabbed interfaces should not contain dropdown menus, as this causes both usability and accessibility issues.
    /// From a usability perspective, the fact that the currently displayed tab’s trigger element is not immediately visible (as it’s inside the closed dropdown menu) can cause confusion. From an accessibility point of view, there is currently no sensible way to map this sort of construct to a standard WAI ARIA pattern, meaning that it cannot be easily made understandable to users of assistive technologies.
    /// </summary>
    public class NavJavaScriptBehaviorManager : AbstractNavManager
    {
        /// <summary>
        /// To make tabs fade in, add .fade to each .tab-pane.
        /// The first tab pane must also have .show to make the initial content visible.
        /// </summary>
        public bool IsFadeStyle { get; set; } = true;

        public Dictionary<string, string> CacheContents { get; private set; } = new Dictionary<string, string>();

        public NavJavaScriptBehaviorManager(string DomId)
        {
            ID = DomId;
        }

        public NavItemManager AddNav(string SetNavHeader, string SetNavId, string SetNavCachedContent)
        {
            NavItemManager navItem = new NavItemManager(SetNavId) { Header = SetNavHeader, Href = "#" + SetNavId, ID = SetNavId + "-tab" };
            navItem.SetAttribute(new Dictionary<string, string>() { { "data-toggle", this.IsTabsStyle ? "tab" : "pill" }, { "role", "tab" }, { "aria-controls", SetNavId } });
            
            Childs.Add(navItem);
            CacheContents.Add(SetNavId, SetNavCachedContent);
            return (NavItemManager)Childs[Childs.Count - 1];
        }        
    }
}
