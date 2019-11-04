////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using System;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class NavReferenceBehaviorManager : AbstractNavManager
    {
        public NavReferenceBehaviorManager(string DomId)
        {
            ID = DomId;
        }

        public NavItemManager AddNav(string SetNavHeader, string SetNavHref, string SetNavId)
        {
            if (string.IsNullOrWhiteSpace(SetNavId))
                throw new ArgumentNullException(nameof(SetNavId));
            if (string.IsNullOrWhiteSpace(SetNavHref))
                throw new ArgumentNullException(nameof(SetNavHref));

            Childs.Add(new NavItemManager(SetNavId) { Header = SetNavHeader, Href = SetNavHref });
            return (NavItemManager)Childs[Childs.Count - 1];
        }
    }
}
