////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using System.Collections.Generic;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class NavJavaScriptBehaviorManager : AbstractNavManager
    {
        protected override short AvailableNestingDepth => 1;
        protected Dictionary<string, string> CacheContents { get; private set; } = new Dictionary<string, string>();

        public void UpdateTab(string SetNavHeader, string SetNavContetnt)
        {

        }
    }
}
