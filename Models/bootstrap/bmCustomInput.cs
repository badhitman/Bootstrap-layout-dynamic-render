////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapAspDynamicRender.service;
using System;

namespace BootstrapAspDynamicRender.models
{
    public class bmCustomInput : bmInput
    {
        public bmCustomInput()
        {

        }

        public bmCustomInput(bmInput input)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));

            HelpCaption = input.HelpCaption;
            Input = input.Input.Clone() as ahsInputs;
            InvalidFeedback = input.InvalidFeedback;
            ValidFeedback = input.ValidFeedback;
            Label = input.Label;
            LabelSrOnly = input.LabelSrOnly;
            SizeInput = input.SizeInput;
        }
    }
}
