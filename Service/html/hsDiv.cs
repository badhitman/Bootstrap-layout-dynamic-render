////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class hsDiv : ahsManagedListNodes
    {
        public override string ViewComponentName => nameof(hrDiv);
    }
}
