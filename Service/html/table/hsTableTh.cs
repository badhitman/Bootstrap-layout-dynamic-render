////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class hsTableTh : ahsManagedListNodes
    {
        public string Header { get; set; }
        public override string ViewComponentName => nameof(hrTableTh);
    }
}
