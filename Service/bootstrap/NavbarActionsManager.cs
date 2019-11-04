using BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class NavbarActionsManager : UniversalListManager
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
            navbarNav.AddCSS("navbar-nav");
            Childs.Add(navbarNav);
        }
    }
}
