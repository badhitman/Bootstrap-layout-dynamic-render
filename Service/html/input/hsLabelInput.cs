////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class hsLabelInput : ahsDom
    {
        public override string ViewComponentName => nameof(hrLabel);

        public string For { get; set; }

        public string Header { get; set; }

        public override string GetStringAttributes()
        {
            if (!string.IsNullOrWhiteSpace(For))
                SetAttribute("for", For);

            return base.GetStringAttributes();
        }
    }
}
