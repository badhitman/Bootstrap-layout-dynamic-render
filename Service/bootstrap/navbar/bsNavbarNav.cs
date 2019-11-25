////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class bsNavbarNav : absCoreNav
    {
        public bmNavbarNavWrappersEnum NavWrapper { get; set; } = bmNavbarNavWrappersEnum.ul;

        public override string ViewComponentName => "brNavWrap" + NavWrapper.ToString().ToUpper();

        public bsNavItem AddNavItem(string id_dom, string header, string href)
        {
            bsNavItem navItem = new bsNavItem(id_dom) { Header = header, Href = href };
            Childs.Add(navItem);
            return navItem;
        }
    }
}
