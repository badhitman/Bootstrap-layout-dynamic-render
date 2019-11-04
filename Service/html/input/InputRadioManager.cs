////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputRadioManager : AbstractInputValuableBoolManager
    {
        public InputRadioManager()
        {
            SetAttribute("type", InputTypesEnum.radio.ToString());
        }
    }
}
