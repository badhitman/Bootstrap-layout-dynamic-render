////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.models;

namespace BootstrapAspDynamicRender.service
{
    public class bsButtonLink : bsButton
    {
        public string Href { get; set; } = "#";

        public bsButtonLink(string SetHeader, string SetHref) : base(SetHeader)
        {
            Href = SetHref;
            this.ButtonType = hmhmButtonTypesEnum.NULL;
        }

        public override string GetStringAttributes()
        {
            SetAttribute("role", "button");
            SetAttribute("href", Href);

            if (IsDisabled)
            {
                Tabindex = -1;
                SetAttribute("aria-disabled", "true");
            }
            return base.GetStringAttributes();
        }

        public override string GetStringCSS()
        {
            if (IsDisabled)
                AddCSS("disabled");

            return base.GetStringCSS();
        }
    }
}
