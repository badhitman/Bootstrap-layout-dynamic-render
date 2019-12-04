////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using System;

namespace BootstrapAspDynamicRender.service
{
    public class bsNavReferenceBehavior : absNav
    {
        public bsNavReferenceBehavior(string DomId)
        {
            ID = DomId;
        }

        public bsNavItem AddNav(string SetNavHeader, string SetNavHref, string SetNavId)
        {
            if (string.IsNullOrWhiteSpace(SetNavId))
                throw new ArgumentNullException(nameof(SetNavId));
            if (string.IsNullOrWhiteSpace(SetNavHref))
                throw new ArgumentNullException(nameof(SetNavHref));

            ChildsNodes.Add(new bsNavItem(SetNavId) { Header = SetNavHeader, Href = SetNavHref });
            return (bsNavItem)ChildsNodes[ChildsNodes.Count - 1];
        }
    }
}
