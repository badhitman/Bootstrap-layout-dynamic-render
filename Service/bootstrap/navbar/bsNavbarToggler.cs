////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class bsNavbarToggler : ahsDom
    {
        public string TargetName { get; set; }

        public override string ViewComponentName => nameof(brNavbarToggler);
    }
}
