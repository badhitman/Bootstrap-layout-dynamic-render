using BootstrapViewComponentsRazorLibrary.Components.bootstrap;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap.forms
{
    public abstract class AbstractFormGroupManager : AbstractNestedToolsManager
    {
        public override string ViewComponentName => nameof(BootstrapRenderFormGroup);

        public override string GetStringCSS()
        {
            AddCSS("form-group");
            return base.GetStringCSS();
        }
    }
}
