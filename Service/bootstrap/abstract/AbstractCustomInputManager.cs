////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap.input
{
    public abstract class AbstractCustomInputManager : ManagedListNodesManager
    {
        LabelInputManager Label;
        AbstractInputDataValuableManager Input;
        public override string ViewComponentName => nameof(CustomInputBase);
    }
}
