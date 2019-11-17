////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputRadioManager : AbstractCheckedInputManager
    {
        public string Value { get; set; }
        
        public InputRadioManager()
        {
            SetAttribute("type", InputTypesEnum.radio.ToString());
        }

        public override string GetStringAttributes()
        {
            SetAttribute("value", Value);
            return base.GetStringAttributes();
        }
    }
}
