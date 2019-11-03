////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.html;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap.navbar
{
    public class UniversalListManager : AbstractNestedToolsManager
    {
        public bool IsHidesCollapse { get; set; } = true;

        public override string ViewComponentName => nameof(UniversalList);

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
