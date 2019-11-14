////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.html.input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public class LabelInputManager : AbstractDomManager
    {
        public override string ViewComponentName => nameof(LabelBase);

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
