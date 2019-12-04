////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////

namespace BootstrapAspDynamicRender.service
{
    public class bsNavbarActions : hsUniversalList
    {
        public bool IsHidesCollapse { get; set; } = true;

        public void AddSubNode(hsForm navbarform)
        {
            navbarform.AddCSS("form-inline");
            ChildsNodes.Add(navbarform);
        }

        public void AddSubNode(bsNavbarText navbarText)
        {
            ChildsNodes.Add(navbarText);
        }

        public void AddSubNode(bsNavbarNav navbarNav)
        {
            navbarNav.AddCSS("navbar-nav");
            ChildsNodes.Add(navbarNav);
        }
    }
}
