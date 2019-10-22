////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar
{
    public class NavbarBodyManager : AbstractSafeNestedToolsManager
    {
        public bool IsHidesCollapse { get; set; } = true;

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
