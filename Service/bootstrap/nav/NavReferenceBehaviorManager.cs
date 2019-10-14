////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class NavReferenceBehaviorManager : AbstractNavManager
    {
        public NavReferenceBehaviorManager(NavOrientationsEnum SetNavigationOrientation, bool SetTabsStyle = false) : base(SetNavigationOrientation, SetTabsStyle)
        {

        }

        public void AddNav(string SetNavHeader, string SetNavId, string SetNavHref)
        {
            NavItems.Add(new NavItemModel(SetNavId) { Header = SetNavHeader, Href = SetNavHref });
        }
    }
}
