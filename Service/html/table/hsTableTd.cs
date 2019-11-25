////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class hsTableTd : ahsManagedListNodes
    {
        public override string ViewComponentName => nameof(hrTableTd);

        public string Header { get; set; }
    }
}
