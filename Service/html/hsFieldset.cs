////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class hsFieldset : ahsManagedListNodes
    {
        public string Legend { get; set; }

        public bool IsDisabled { get; set; } = false;

        public override string ViewComponentName => nameof(hrFieldset);

        public override string GetStringAttributes()
        {
            if (IsDisabled)
                SetAttribute("disabled", "disabled");

            return base.GetStringAttributes();
        }
    }
}
