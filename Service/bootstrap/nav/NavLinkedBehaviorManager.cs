////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class NavStandartBehaviorManager: AbstractNavManager
    {
        protected override short AvailableNestingDepth => 2;

        public void UpdateTab(string SetNavHeader, string SetNavHref)
        {

        }
    }
}
