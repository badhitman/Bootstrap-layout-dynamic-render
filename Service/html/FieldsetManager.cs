using System;
using System.Collections.Generic;
using System.Text;
using BootstrapViewComponentsRazorLibrary.Components.html;

namespace BootstrapViewComponentsRazorLibrary.Service.html
{
    public class FieldsetManager : ManagedListNodesManager
    {
        public string Legend { get; set; }

        public bool IsDisabled { get; set; } = false;

        public override string ViewComponentName => nameof(HtmlRenderFieldset);

        public override string GetStringAttributes()
        {
            if (IsDisabled)
                SetAttribute("disabled", "disabled");

            return base.GetStringAttributes();
        }
    }
}
