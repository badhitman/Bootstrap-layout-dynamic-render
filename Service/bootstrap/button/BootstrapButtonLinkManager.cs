using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Models.html;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap
{
    public class BootstrapButtonLinkManager : BootstrapButtonManager
    {
        public string Href { get; set; } = "#";

        public BootstrapButtonLinkManager(string SetHeader, string SetHref) : base(SetHeader)
        {
            Href = SetHref;
            this.ButtonType = ButtonTypesEnum.NULL;
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
