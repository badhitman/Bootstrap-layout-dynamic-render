////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.bootstrap;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service
{
    public class FormManager : AbstractNestedToolsManager
    {
        public override string ViewComponentName => nameof(FormBase);
    }
}
