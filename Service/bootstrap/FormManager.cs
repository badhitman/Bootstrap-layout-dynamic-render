////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.bootstrap;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service
{
    public class FormManager : AbstractSafeNestedToolsManager
    {
        public override string ViewComponentName => nameof(FormBase);
    }
}
