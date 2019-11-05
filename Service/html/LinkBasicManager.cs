using BootstrapViewComponentsRazorLibrary.Components.html;
using BootstrapViewComponentsRazorLibrary.Models.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public class LinkBasicManager : AbstractDomManager
    {
        public override string ViewComponentName => nameof(HtmlRenderLink);

        public string Header { get; set; }

        public string Href { get; set; }

        public BrowserTargetsEnum Target { get; set; } = BrowserTargetsEnum._blank;

        public override string GetStringAttributes()
        {
            //get
            //{
                if (Target != BrowserTargetsEnum.NULL)
                    SetAttribute("target", Target.ToString());

                if (!string.IsNullOrWhiteSpace(Href))
                    SetAttribute("href", Href);

                return base.GetStringAttributes();
            //}
        }
    }
}
