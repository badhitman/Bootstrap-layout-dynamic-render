////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputPasswordManager : AbstractTextedInputManager
    {
        public InputPasswordManager()
        {
            SetAttribute("type", InputTypesEnum.password.ToString());
        }
    }
}
