////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////

namespace BootstrapAspDynamicRender.service
{
    public class bsInputGroupPrepend : absInputGroupFacet
    {
        public override string GetStringCSS()
        {
            AddCSS("input-group-prepend");
            return base.GetStringCSS();
        }
    }
}
