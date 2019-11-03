using BootstrapViewComponentsRazorLibrary.Components.html.input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public class LabelManager : AbstractDomManager
    {
        public override string ViewComponentName => nameof(LabelBase);

        public string For { get; set; }

        public string Header { get; set; }

        public override string StringAttributes
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(For))
                    SetAttribute("for",For);

                return base.StringAttributes;
            }
        }
    }
}
