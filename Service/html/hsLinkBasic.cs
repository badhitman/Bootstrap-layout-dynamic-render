////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.components;
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class hsLinkBasic : ahsDom
    {
        public override string ViewComponentName => nameof(hrLink);

        public string Header { get; set; }

        public string Href { get; set; }

        public hmFormTargetsEnum Target { get; set; } = hmFormTargetsEnum._blank;

        public override string GetStringAttributes()
        {
            if (Target != hmFormTargetsEnum.NULL)
                SetAttribute("target", Target.ToString());

            if (!string.IsNullOrWhiteSpace(Href))
                SetAttribute("href", Href);

            return base.GetStringAttributes();
        }
    }
}
