using BootstrapViewComponentsRazorLibrary.Components.bootstrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap.forms
{
    public abstract class AbstractFormGroupManager : AbstractNestedToolsManager
    {
        public override string ViewComponentName => nameof(BootstrapRenderFormGroup);

        public override string GetStringCSS()
        {
            if (!ContainsClassCSS(delegate (string s) { return s == "form-row"; }))
                AddCSS("form-group");

            return base.GetStringCSS();
        }
    }
}
