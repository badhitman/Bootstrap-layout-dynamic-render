////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using System.Collections.Generic;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class NavJavaScriptBehaviorManager : AbstractNavManager
    {
        protected Dictionary<string, string> CacheContents { get; private set; } = new Dictionary<string, string>();

        public NavJavaScriptBehaviorManager(NavOrientationsEnum SetNavigationOrientation, bool SetTabsStyle = false) : base(SetNavigationOrientation, SetTabsStyle)
        {

        }

        public void UpdateNav(string SetNavHeader, string SetNavId, string SetNavCachedContent)
        {

        }
    }
}
