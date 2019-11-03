////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////
using BootstrapViewComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapViewComponentsRazorLibrary.Service.html.input
{
    public class InputRangeManager : AbstractTextedInputManager
    {
        public InputRangeManager()
        {
            SetAttribute("type", InputTypesEnum.range.ToString());
        }
    }
}
