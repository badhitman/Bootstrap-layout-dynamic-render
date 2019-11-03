////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputEmailManager : AbstractTextedInputManager
    {
        public InputEmailManager()
        {
            SetAttribute("type", InputTypesEnum.email.ToString());
        }
    }
}
