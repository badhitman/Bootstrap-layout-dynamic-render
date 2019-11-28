using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    public class hsRaw : ahsDom
    {
        public override string ViewComponentName => nameof(hrRaw);

        public string HtmlRaw { get; set; }

        public hsRaw(string SetHtmlRaw)
        {
            HtmlRaw = SetHtmlRaw;
        }
    }
}
