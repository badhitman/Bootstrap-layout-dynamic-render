////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponentsRazorLibrary.Components.bootstrap;
using BootstrapViewComponentsRazorLibrary.Models.bootstrap;
using BootstrapViewComponentsRazorLibrary.Service.html;
using BootstrapViewComponentsRazorLibrary.Service.html.input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.bootstrap.input
{
    public class CustomInputModel
    {
        public string Label { get; set; }
        public bool LabelSrOnly { get; set; } = false;


        public AbstractInputManager Input { get; set; }
        public bool IsInputCustomStyle { get; set; } = false;

        public string HelpCaption { get; set; }

        public TwinSizingEnum SizeInput { get; set; } = TwinSizingEnum.NULL;

        public string ValidFeedback { get; set; }

        public string InvalidFeedback { get; set; }
    }
}
