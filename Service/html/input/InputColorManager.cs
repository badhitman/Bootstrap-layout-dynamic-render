////////////////////////////////////////////////
// https://github.com/badhitman
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputColorManager : AbstractTextedInputManager
    {
        public InputColorManager()
        {
            SetAttribute("type", InputTypesEnum.color.ToString());
        }
    }
}
