////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.html.input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class OptionSelectInputManager : AbstractDomManager
    {
        public override string ViewComponentName => nameof(OptionSelectBase);

        public string Header { get; set; }

        public string Value { get; set; }

        public override string StringAttributes
        {
            get
            {
                SetAttribute("value", Value);
                return base.StringAttributes;
            }
        }
    }
}
