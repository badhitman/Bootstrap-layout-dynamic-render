////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputTextManager: AbstractTextedInputManager
    {
        public InputTextManager()
        {
            SetAttribute("type", InputTypesEnum.text.ToString());
        }
    }
}
