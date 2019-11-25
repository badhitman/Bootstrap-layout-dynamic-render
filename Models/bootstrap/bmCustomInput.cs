////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;

namespace BootstrapAspDynamicRender.models
{
    public class bmCustomInput
    {
        /// <summary>
        /// Строка, добавляемая к form-group родителю
        /// </summary>
        public string AddedClassesCSS { get; set; }

        public string Label { get; set; }
        public bool LabelSrOnly { get; set; } = false;


        public ahsInputs Input { get; set; }
        public string CustomStyleInput { get; set; }

        public string HelpCaption { get; set; }

        public bmTwinSizingsEnum SizeInput { get; set; } = bmTwinSizingsEnum.NULL;

        public string ValidFeedback { get; set; }

        public string InvalidFeedback { get; set; }
    }
}
