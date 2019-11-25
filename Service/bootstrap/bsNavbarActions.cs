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
            Childs.Add(navbarform);
        }

        public void AddSubNode(bsNavbarText navbarText)
        {
            Childs.Add(navbarText);
        }

        public void AddSubNode(bsNavbarNav navbarNav)
        {
            navbarNav.AddCSS("navbar-nav");
            Childs.Add(navbarNav);
        }
    }
}
