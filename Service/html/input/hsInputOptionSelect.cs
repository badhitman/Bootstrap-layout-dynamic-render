////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class hsInputOptionSelect : ahsDom
    {
        public override string ViewComponentName => nameof(hrSelectOption);

        public bool IsSelect { get; set; } = false;

        public string Header { get; set; }

        public string Value { get; set; }

        public override string GetStringAttributes()
        {
            if (IsSelect)
                SetAttribute("select", null);
            else
                RemoveAttribute("select");

            if (!string.IsNullOrWhiteSpace(Value))
                SetAttribute("value", Value);
            else
                RemoveAttribute("value");

            return base.GetStringAttributes();
        }
    }
}
