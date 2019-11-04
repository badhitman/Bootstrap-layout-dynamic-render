////////////////////////////////////////////////
// https://github.com/badhitman
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
        public LabelInputManager Label { get; set; }

        public AbstractInputManager Input { get; set; }

        public string HelpCaption { get; set; }

        public string ValidFeedback { get; set; } = "Looks good!";

        public string InvalidFeedback { get; set; }

        public override string ViewComponentName => nameof(CustomInputBase);
    }
}
