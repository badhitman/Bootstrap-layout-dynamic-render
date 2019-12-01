using BootstrapAspDynamicRender.components;

namespace BootstrapAspDynamicRender.service
{
    /// <summary>
    /// Универсальный сервис для рендеринга произвольного текста как raw HTML
    /// </summary>
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
