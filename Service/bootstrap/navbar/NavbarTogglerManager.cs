////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.bootstrap.navbar;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar
{
    public class NavbarTogglerManager : AbstractDomManager
    {
        public string TargetName { get; set; }

        public override string ViewComponentName => nameof(NavbarToggler);
    }
}
