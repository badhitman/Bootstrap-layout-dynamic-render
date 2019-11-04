////////////////////////////////////////////////
// MIT License. https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputDateManager : AbstractTextedInputManager
    {
        public InputDateManager()
        {
            SetAttribute("type", InputTypesEnum.date.ToString());
        }
    }
}
