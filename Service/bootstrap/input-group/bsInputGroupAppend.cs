////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////

namespace BootstrapAspDynamicRender.service
{
    public class bsInputGroupAppend : absInputGroupFacet
    {
        public override string GetStringCSS()
        {
            AddCSS("input-group-append");
            return base.GetStringCSS();
        }
    }
}
