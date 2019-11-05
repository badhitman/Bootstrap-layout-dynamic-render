using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
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
        }

        public override string GetStringAttributes()
        {
            SetAttribute("role", "button");
            SetAttribute("href", Href);
            return base.GetStringAttributes();
        }
    }
}
