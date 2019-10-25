////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using System;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class NavReferenceBehaviorManager : AbstractNavManager
    {
        public NavReferenceBehaviorManager(string DomId)
        {
            Id_DOM = DomId;
        }

        public NavItemModel AddNav(string SetNavHeader, string SetNavId, string SetNavHref)
        {
            if (string.IsNullOrWhiteSpace(SetNavId))
                throw new ArgumentNullException(nameof(SetNavId));
            if (string.IsNullOrWhiteSpace(SetNavHref))
                throw new ArgumentNullException(nameof(SetNavHref));

            Childs.Add(new NavItemModel(SetNavId) { Header = SetNavHeader, Href = SetNavHref });
            return (NavItemModel)Childs[Childs.Count - 1];
        }
    }
}
