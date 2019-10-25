////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.bootstrap.navbar;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar
{
    public class NavbarBodyManager : AbstractNestedToolsManager
    {
        public bool IsHidesCollapse { get; set; } = true;

        public override string ViewComponentName => nameof(NavbarBody);

        public void AddSubNode(FormManager navbarform)
        {
            navbarform.AddCSS("form-inline");
            Childs.Add(navbarform);
        }

        public void AddSubNode(NavbarTextManager navbarText)
        {
            Childs.Add(navbarText);
        }

        public void AddSubNode(NavbarNavManager navbarNav)
        {
            Childs.Add(navbarNav);
        }
    }
}
